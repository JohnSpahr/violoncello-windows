using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Violoncello
{
    public partial class SearchEngine : Form
    {
        public SearchEngine()
        {
            InitializeComponent();
        }

        private void SearchEngine_Load(object sender, EventArgs e)
        {
            //searchEngineBox.SelectedIndex = 0;

            switch (queryTxt.Text)
            {
                case "https://bing.com/search?q=":
                    searchEngineBox.SelectedIndex = 0;
                    break;

                case "https://google.com/search?q=":
                    searchEngineBox.SelectedIndex = 1;
                    break;

                case "https://html.duckduckgo.com/html/?q=":
                    searchEngineBox.SelectedIndex = 2;
                    break;

                case "https://en.wikipedia.org/wiki/Special:Search/":
                    searchEngineBox.SelectedIndex = 3;
                    break;
                default:
                    searchEngineBox.SelectedIndex = 4;
                    break;
            }
        }

        private void queryTxt_TextChanged(object sender, EventArgs e)
        {
            //switch to custom mode if not preset
            if (queryTxt.Text != "https://bing.com/search?q=" && queryTxt.Text != "https://google.com/search?q=" & queryTxt.Text != "https://html.duckduckgo.com/html/?q=" && queryTxt.Text != "https://en.wikipedia.org/wiki/Special:Search/")
            {
                searchEngineBox.SelectedIndex = searchEngineBox.Items.Count - 1;
            }
        }

        private void searchEngineBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (searchEngineBox.SelectedIndex)
            {
                case 0: //Bing
                    queryTxt.Text = "https://bing.com/search?q=";
                    break;

                case 1: //Google
                    queryTxt.Text = "https://google.com/search?q=";
                    break;

                case 2: //DuckDuckGo
                    queryTxt.Text = "https://html.duckduckgo.com/html/?q=";
                    break;

                case 3: //Wikipedia
                    queryTxt.Text = "https://en.wikipedia.org/wiki/Special:Search/";
                    break;
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
