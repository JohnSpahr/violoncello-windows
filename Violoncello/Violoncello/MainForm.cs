using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using NSoup.Nodes;

namespace Violoncello
{
    public partial class MainForm : Form
    {
        private string currentSite = "about:home";
        private string currentTitle = "Home";
        private List<string> backList = new List<string>();

        public MainForm()
        {
            InitializeComponent();

            try
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; //TLS 1.2;
            }
            catch (Exception)
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls; //switch to TLS 1.0 if 1.2 doesn't work
            }
        }

        private void LoadSite(string url)
        {
            try
            {
                statusPB.Invoke((MethodInvoker)delegate
                {
                    //show loading GIF
                    statusPB.Image = Properties.Resources.loading;
                });

                try
                {
                    //add currentsite to backlist before navigating
                    if (backList[backList.Count - 1] != currentSite)
                    {
                        backList.Add(currentSite);
                    }
                }
                catch (Exception)
                {
                    backList.Add(currentSite);
                }

                //navigate or search
                if (url.Contains("."))
                {
                    if (!url.Contains("http") && !url.Contains("://"))
                    {
                        url = "http://" + url;
                    }
                }
                else
                {
                    url = Properties.Settings.Default.query + url;
                }

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url); //request site at URL
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36"; //set user agent to Chrome 80
                HttpWebResponse response = (HttpWebResponse)request.GetResponse(); //get response from site
                url = response.ResponseUri.ToString(); //get updated URL if redirection occurs
                Stream dataStream = response.GetResponseStream(); //get site data stream
                StreamReader reader = new StreamReader(dataStream); //read data stream
                string html = reader.ReadToEnd(); //get HTML
                response.Close();

                //create Nsoup document from HTML string
                Document output = NSoup.Parse.Parser.Parse(html.ToString(), url);

                //update currentSite variable with new URL
                currentSite = url;

                //update currentTitle variable with new title
                currentTitle = output.Title;

                //update form text with title
                Invoke((MethodInvoker)delegate
                {
                    Text = output.Title + " - Violoncello";
                });

                output.Select("title").Remove();

                output.BaseUri = url;

                //make relative links absolute
                foreach (var tag in output.GetElementsByTag("a"))
                {
                    if (!tag.ToString().Contains("http") && !tag.ToString().Contains("://"))
                    {
                        string absURL = tag.AbsUrl("href");
                        tag.Attr("href", absURL);
                    }
                }

                //remove everything but text from HTML
                var site = NSoup.NSoupClient.Clean(output.ToString(), NSoup.Safety.Whitelist.Basic.AddTags("a", "b", "blockquote", "br", "caption", "cite", "code", "col", "colgroup", "dd", "div", "dl", "dt", "em", "h1", "h2", "h3", "h4", "h5", "h6", "i", "li", "ol", "p", "pre", "q", "small", "span", "strike", "strong", "sub", "sup", "table", "tbody", "td", "tfoot", "th", "thead", "tr", "u", "ul"));
                site = site + "<br><br>";

                //update navigation bar URL
                urlTxt.Invoke((MethodInvoker)delegate
                {
                    urlTxt.Text = url;
                });

                //navigate to new site, applying customization settings
                webView.Invoke((MethodInvoker)delegate
                {
                    fontSetup();
                    webView.ResetText();

                    //try to update webView document
                    try
                    {
                        webView.Text = site.Trim();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("This page could not be opened in Violoncello.", "Failed to load page...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });

                //update secure/not secure picture
                if (url.Contains("https://"))
                {
                    statusPB.Invoke((MethodInvoker)delegate
                    {
                        statusPB.Image = Properties.Resources.secure;
                    });
                }
                else
                {
                    statusPB.Invoke((MethodInvoker)delegate
                    {
                        statusPB.Image = Properties.Resources.insecure;
                    });
                }
            }
            catch (Exception)
            {
                //report error if unable to load page
                statusPB.Invoke((MethodInvoker)delegate
                {
                    statusPB.Image = Properties.Resources.logo;
                });
                MessageBox.Show("Violoncello could not load the webpage you requested. Make sure you are connected to the internet, check the URL for typos, and try again.", "Error loading page...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fontSetup()
        {
            //set background color
            webView.BackColor = backgroundColorDialog.Color;

            //get and set font style and weight
            string fontStyle = "normal";
            string fontWeight = "normal";

            if (fontDialog.Font.Style.ToString().Contains(","))
            {
                string[] fontInfo = fontDialog.Font.Style.ToString().Split(',');
                fontWeight = fontInfo[0].Trim(); //get font weight
                fontStyle = fontInfo[1].Trim(); //get font style
            }
            else if (fontDialog.Font.Style.ToString().Contains("Bold"))
            {
                fontWeight = "bold";
            }
            else if (fontDialog.Font.Style.ToString().Contains("Italic"))
            {
                fontStyle = "italic";
            }

            webView.BaseStylesheet = "a, b, blockquote, br, caption, cite, code, col, colgroup, dd, div, dl, dt, em, i, li, ol, p, pre, q, small, span, strike, strong, sub, sup, table, tbody, td, tfoot, th, thead, tr, u, ul { color: #" + (textColorDialog.Color.ToArgb() & 0x00FFFFFF).ToString("X6") + "; font-family: " + fontDialog.Font.FontFamily.Name + "; font-style: " + fontStyle + "; font-weight: " + fontWeight + "; font-size: " + fontDialog.Font.Size.ToString() + "px; } h1, h2, h3, h4, h5, h6 { color: #" + (textColorDialog.Color.ToArgb() & 0x00FFFFFF).ToString("X6") + "; font-family: " + fontDialog.Font.FontFamily.Name + "; font-style: " + fontStyle + "; font-weight: " + fontWeight + "; font-size: " + (fontDialog.Font.Size * 2).ToString() + "px; }";
        }

        private void urlTxt_KeyDown(object sender, KeyEventArgs e)
        {
            //navigate when enter key pressed in navigation bar textbox
            if (e.KeyCode == Keys.Enter)
            {
                //load site if textbox isn't blank
                if (urlTxt.Text.Trim() != "")
                {
                    Task.Factory.StartNew(() => LoadSite(urlTxt.Text));
                }

                //gets rid of the Windows error noise
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            //reload page depending if you're on the homepage or not
            if (currentSite != "about:home")
            {
                Task.Factory.StartNew(() => LoadSite(currentSite));
            }
            else
            {
                //if at homepage...
                homeLoad();
            }
        }

        private void homeLoad()
        {
            //load homepage with tip and customization settings
            string[] tips = { "If you visit <b>Settings → Search Engine</b>, you can choose which search engine you would like to use. You can even set a custom one!", "The <b>'bookmarks.ini'</b> file is where all of your bookmarks are stored. Make sure that you don't delete it!", "Violoncello lets you change a page's font, background color, and text color for easier reading! You can do all of these things in the <b>'Customization'</b> menu.", "There is also an Android version of Violoncello! You can get it on Google Play.", "Want to view a page in your default browser? Simply press <b>Ctrl+B</b>!", "If you go to <b>Settings → Reset → Bookmarks</b>, you can easily remove all of your bookmarks.", "There are several key shortcuts for functions such as going back, reloading the page, and jumping to the top of the page. You can find them in the application menus." };
            fontSetup();
            webView.ResetText();
            webView.Text = "<!DOCTYPE html><html><body><h1>Welcome to Violoncello!</h1><p><b>Tip:</b> " + tips[new Random().Next(tips.Length)] + "</p></body></html>";
        }

        private void topBtn_Click(object sender, EventArgs e)
        {
            //scroll to 0, 0
            webView.VerticalScroll.Value = 0;
            webView.HorizontalScroll.Value = 0;
        }

        private void bookmarkBtn_Click(object sender, EventArgs e)
        {
            //add bookmark if not for homepage
            if (currentSite != "about:home")
            {
                if (currentTitle.Trim() != "")
                {
                    favoritesList.Items.Add(currentTitle + " | " + currentSite);
                }
                else
                {
                    favoritesList.Items.Add(currentSite);
                }

                MessageBox.Show("Added bookmark: " + favoritesList.Items[favoritesList.Items.Count - 1], "Bookmarks", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You cannot bookmark this page.", "Bookmarks", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //set padding to 5
            webView.Padding = new Padding(5);

            //update menus to have gray color scheme
            menuStrip.Renderer = new ToolStripProfessionalRenderer(new MenuClass());
            bookmarkMenu.Renderer = new ToolStripProfessionalRenderer(new MenuClass());

            //if stay on top is checked...
            if (Properties.Settings.Default.stayOnTopCheckState == CheckState.Checked)
            {
                stayOnTopBtn.Checked = true;
                TopMost = true;
                Focus();
                TopMost = true;
            }

            //load bookmarks from bookmarks.ini file
            if (File.Exists("bookmarks.ini"))
            {
                StreamReader sr = new StreamReader("bookmarks.ini");

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.ToString().Trim() != "")
                    {
                        favoritesList.Items.Add(line.ToString());
                    }
                }

                sr.Close();
            }

            //get favorites
            fetchFavorites();

            //load homepage
            homeLoad();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save bookmarks when form is closing
            StreamWriter sw = new StreamWriter("bookmarks.ini");

            foreach (var item in favoritesList.Items)
            {
                sw.WriteLine(item);
            }

            sw.Close();
        }

        private void fetchFavorites()
        {
            //get favorites and add them to menu
            if (favoritesList.Items.Count > 0)
            {
                bookmarksMenuItem.DropDownItems.Add(new ToolStripSeparator());
            }

            //loop through bookmarks...
            foreach (var item in favoritesList.Items)
            {
                string bookmark = item.ToString();

                if (bookmark.Trim() != "")
                {
                    //create menu item for each bookmark
                    MenuItem menuItem = new MenuItem();
                    menuItem.Text = bookmark;

                    //add click event to each item
                    bookmarksMenuItem.DropDownItems.Add(bookmark).Click += delegate
                    {
                        //show context menu for bookmark with visit and delete buttons
                        bookmarkMenu.Show(MousePosition.X, MousePosition.Y);
                        bookmarkNameBtn.Text = bookmark;

                        //if visit option chosen...
                        visitBookmarkBtn.Click += delegate
                        {
                            //eliminate title if needed, then load site
                            int idx = bookmark.LastIndexOf(" | ");
                            if (idx != -1)
                            {
                                string bookmarkURL = bookmark.Substring(idx + 1);
                                bookmarkURL = bookmarkURL.Replace("|", "").Trim();
                                Task.Factory.StartNew(() => LoadSite(bookmarkURL));
                            }
                            else
                            {
                                Task.Factory.StartNew(() => LoadSite(bookmark));
                            }
                        };

                        //if remove option chosen...
                        removeBookmarkBtn.Click += delegate
                        {
                            favoritesList.Items.Remove(item);
                        };
                    };
                }
            }
        }

        private void bookmarksMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            //reset bookmarks menu
            bookmarksMenuItem.DropDownItems.Clear();
            bookmarksMenuItem.DropDownItems.Add(bookmarkBtn);

            //update favorites menu
            fetchFavorites();
        }

        private void mainBrowserBtn_Click(object sender, EventArgs e)
        {
            //open in main browser
            if (currentSite != "about:home")
            {
                Process.Start(currentSite);
            }
            else
            {
                MessageBox.Show("This page cannot be opened in your default browser.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fontBtn_Click(object sender, EventArgs e)
        {
            //show font dialog and save settings
            fontDialog.ShowDialog();
            Properties.Settings.Default.fontPreference = fontDialog.Font;
            Properties.Settings.Default.Save();
        }

        private void textColorBtn_Click(object sender, EventArgs e)
        {
            //show text color dialog and save settings
            textColorDialog.ShowDialog();
            Properties.Settings.Default.textColor = textColorDialog.Color;
            Properties.Settings.Default.Save();
        }

        private void backgroundColorBtn_Click(object sender, EventArgs e)
        {
            //show background color dialog and save settings
            backgroundColorDialog.ShowDialog();
            Properties.Settings.Default.backgroundColor = backgroundColorDialog.Color;
            Properties.Settings.Default.Save();
        }

        private void menuItem_DropDownOpened(object sender, EventArgs e)
        {
            //when dropdown menu opened, change background color to black so it's possible to read
            var menuItem = (ToolStripMenuItem)sender;
            menuItem.ForeColor = Color.Black;
        }

        private void menuItem_DropDownClosed(object sender, EventArgs e)
        {
            //revert back to white text when dropdown menu closes for readability
            var menuItem = (ToolStripMenuItem)sender;
            menuItem.ForeColor = Color.White;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //go back if backList has more than one item...
            if (backList.Count > 1)
            {
                //load site and update lists
                backListDuplicateCheck();
                if (backList[backList.Count - 1] != "about:home")
                {
                    Task.Factory.StartNew(() => LoadSite(backList[backList.Count - 1])).ContinueWith(task => backList.RemoveAt(backList.Count - 1));
                }
            }
        }

        private void backListDuplicateCheck()
        {
            //remove duplicates in backList
            try
            {
                if (currentSite == backList[backList.Count - 1])
                {
                    if (backList.Count > 1)
                    {
                        backList.RemoveAt(backList.Count - 1);
                    }
                }
            }
            catch (Exception)
            {
                //if some sort of exception occurs, just ignore it.
            }
        }

        private void bookmarksResetBtn_Click(object sender, EventArgs e)
        {
            //clear bookmarks
            if (MessageBox.Show("Are you sure you want to clear all of your bookmarks?", "Clear Bookmarks", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                favoritesList.Items.Clear();
            }
        }

        private void customizationResetBtn_Click(object sender, EventArgs e)
        {
            //reset customization settings
            if (MessageBox.Show("Are you sure you want to reset all of your customization settings?", "Reset Customization Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fontDialog.Font = new FontConverter().ConvertFromString("Segoe UI, 16pt") as Font;
                backgroundColorDialog.Color = Color.White;
                textColorDialog.Color = Color.Black;

                //save settings
                Properties.Settings.Default.fontPreference = fontDialog.Font;
                Properties.Settings.Default.backgroundColor = backgroundColorDialog.Color;
                Properties.Settings.Default.textColor = textColorDialog.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show about box
            new About_Box().ShowDialog();
        }

        private void searchEngineBtn_Click(object sender, EventArgs e)
        {
            //show search engine box
            new SearchEngine().ShowDialog();
        }

        private void webView_LinkClicked(object sender, TheArtOfDev.HtmlRenderer.Core.Entities.HtmlLinkClickedEventArgs e)
        {
            //handle link clicks
            e.Handled = true;
            Task.Factory.StartNew(() => LoadSite(e.Link));
        }

        private void pageInfoBtn_Click(object sender, EventArgs e)
        {
            //show page info
            if (currentSite != "about:home")
            {
                bool secure = false;

                if (currentSite.Contains("https://"))
                {
                    secure = true;
                }

                MessageBox.Show("Title: " + currentTitle + "\n\nURL: " + currentSite + "\n\nSecure: " + secure.ToString(), "Page Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You are currently viewing the Violoncello homepage. This page is shown every time you start Violoncello.", "Page Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (currentSite != "about:home")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "HTML File (*.html)|*.html";
                sfd.Title = "Save Page";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //save current page
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    sw.Write(webView.Text);
                    sw.Close();

                    Process.Start("explorer.exe", "/select,\"" + sfd.FileName + "\"");
                }
            }
            else
            {
                MessageBox.Show("This page cannot be saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stayOnTopBtn_Click(object sender, EventArgs e)
        {
            //when check state changes...
            Properties.Settings.Default.stayOnTopCheckState = stayOnTopBtn.CheckState;
            Properties.Settings.Default.Save();

            TopMost = stayOnTopBtn.Checked;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            //close the app
            Application.Exit();
        }
    }
}
