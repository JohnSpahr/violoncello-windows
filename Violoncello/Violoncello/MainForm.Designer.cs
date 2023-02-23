using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Violoncello
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.browserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainBrowserBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.pageInfoBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.fontBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEngineBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.resetBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizationResetBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarksResetBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.stayOnTopBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urlTxt = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.topBtn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.favoritesList = new System.Windows.Forms.ListBox();
            this.bookmarkMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bookmarkNameBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.visitBookmarkBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBookmarkBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.statusPB = new System.Windows.Forms.PictureBox();
            this.webView = new TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.textColorDialog = new System.Windows.Forms.ColorDialog();
            this.backgroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.bookmarkMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusPB)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browserMenuItem,
            this.bookmarksMenuItem,
            this.toolStripMenuItem5,
            this.toolStripMenuItem4});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(900, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // browserMenuItem
            // 
            this.browserMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.jumpToTopToolStripMenuItem,
            this.toolStripSeparator1,
            this.mainBrowserBtn,
            this.saveBtn,
            this.pageInfoBtn,
            this.toolStripSeparator3,
            this.closeBtn});
            this.browserMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browserMenuItem.ForeColor = System.Drawing.Color.White;
            this.browserMenuItem.Name = "browserMenuItem";
            this.browserMenuItem.Size = new System.Drawing.Size(81, 24);
            this.browserMenuItem.Text = "Browser";
            this.browserMenuItem.DropDownClosed += new System.EventHandler(this.menuItem_DropDownClosed);
            this.browserMenuItem.DropDownOpened += new System.EventHandler(this.menuItem_DropDownOpened);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backToolStripMenuItem.Image")));
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloadToolStripMenuItem.Image")));
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // jumpToTopToolStripMenuItem
            // 
            this.jumpToTopToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("jumpToTopToolStripMenuItem.Image")));
            this.jumpToTopToolStripMenuItem.Name = "jumpToTopToolStripMenuItem";
            this.jumpToTopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.jumpToTopToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.jumpToTopToolStripMenuItem.Text = "Jump to top";
            this.jumpToTopToolStripMenuItem.Click += new System.EventHandler(this.topBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(302, 6);
            // 
            // mainBrowserBtn
            // 
            this.mainBrowserBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mainBrowserBtn.Image = ((System.Drawing.Image)(resources.GetObject("mainBrowserBtn.Image")));
            this.mainBrowserBtn.Name = "mainBrowserBtn";
            this.mainBrowserBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mainBrowserBtn.Size = new System.Drawing.Size(305, 26);
            this.mainBrowserBtn.Text = "Open in main browser";
            this.mainBrowserBtn.Click += new System.EventHandler(this.mainBrowserBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveBtn.Size = new System.Drawing.Size(305, 26);
            this.saveBtn.Text = "Save page";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // pageInfoBtn
            // 
            this.pageInfoBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageInfoBtn.Image = ((System.Drawing.Image)(resources.GetObject("pageInfoBtn.Image")));
            this.pageInfoBtn.Name = "pageInfoBtn";
            this.pageInfoBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.pageInfoBtn.Size = new System.Drawing.Size(305, 26);
            this.pageInfoBtn.Text = "Page info";
            this.pageInfoBtn.Click += new System.EventHandler(this.pageInfoBtn_Click);
            // 
            // bookmarksMenuItem
            // 
            this.bookmarksMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookmarkBtn});
            this.bookmarksMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookmarksMenuItem.ForeColor = System.Drawing.Color.White;
            this.bookmarksMenuItem.Name = "bookmarksMenuItem";
            this.bookmarksMenuItem.Size = new System.Drawing.Size(102, 24);
            this.bookmarksMenuItem.Text = "Bookmarks";
            this.bookmarksMenuItem.DropDownClosed += new System.EventHandler(this.menuItem_DropDownClosed);
            this.bookmarksMenuItem.DropDownOpening += new System.EventHandler(this.bookmarksMenuItem_DropDownOpening);
            this.bookmarksMenuItem.DropDownOpened += new System.EventHandler(this.menuItem_DropDownOpened);
            // 
            // bookmarkBtn
            // 
            this.bookmarkBtn.Image = ((System.Drawing.Image)(resources.GetObject("bookmarkBtn.Image")));
            this.bookmarkBtn.Name = "bookmarkBtn";
            this.bookmarkBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.bookmarkBtn.Size = new System.Drawing.Size(288, 26);
            this.bookmarkBtn.Text = "Bookmark this page";
            this.bookmarkBtn.Click += new System.EventHandler(this.bookmarkBtn_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundBtn,
            this.textColorBtn,
            this.fontBtn});
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(96, 24);
            this.toolStripMenuItem5.Text = "Customize";
            this.toolStripMenuItem5.DropDownClosed += new System.EventHandler(this.menuItem_DropDownClosed);
            this.toolStripMenuItem5.DropDownOpened += new System.EventHandler(this.menuItem_DropDownOpened);
            // 
            // backgroundBtn
            // 
            this.backgroundBtn.Image = ((System.Drawing.Image)(resources.GetObject("backgroundBtn.Image")));
            this.backgroundBtn.Name = "backgroundBtn";
            this.backgroundBtn.Size = new System.Drawing.Size(215, 26);
            this.backgroundBtn.Text = "Background color";
            this.backgroundBtn.Click += new System.EventHandler(this.backgroundColorBtn_Click);
            // 
            // textColorBtn
            // 
            this.textColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("textColorBtn.Image")));
            this.textColorBtn.Name = "textColorBtn";
            this.textColorBtn.Size = new System.Drawing.Size(215, 26);
            this.textColorBtn.Text = "Text color";
            this.textColorBtn.Click += new System.EventHandler(this.textColorBtn_Click);
            // 
            // fontBtn
            // 
            this.fontBtn.Image = ((System.Drawing.Image)(resources.GetObject("fontBtn.Image")));
            this.fontBtn.Name = "fontBtn";
            this.fontBtn.Size = new System.Drawing.Size(215, 26);
            this.fontBtn.Text = "Font";
            this.fontBtn.Click += new System.EventHandler(this.fontBtn_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchEngineBtn,
            this.resetBookmarksToolStripMenuItem,
            this.stayOnTopBtn,
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 24);
            this.toolStripMenuItem4.Text = "Settings";
            this.toolStripMenuItem4.DropDownClosed += new System.EventHandler(this.menuItem_DropDownClosed);
            this.toolStripMenuItem4.DropDownOpened += new System.EventHandler(this.menuItem_DropDownOpened);
            // 
            // searchEngineBtn
            // 
            this.searchEngineBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchEngineBtn.Image")));
            this.searchEngineBtn.Name = "searchEngineBtn";
            this.searchEngineBtn.Size = new System.Drawing.Size(189, 26);
            this.searchEngineBtn.Text = "Search engine";
            this.searchEngineBtn.Click += new System.EventHandler(this.searchEngineBtn_Click);
            // 
            // resetBookmarksToolStripMenuItem
            // 
            this.resetBookmarksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizationResetBtn,
            this.bookmarksResetBtn});
            this.resetBookmarksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resetBookmarksToolStripMenuItem.Image")));
            this.resetBookmarksToolStripMenuItem.Name = "resetBookmarksToolStripMenuItem";
            this.resetBookmarksToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.resetBookmarksToolStripMenuItem.Text = "Reset";
            // 
            // customizationResetBtn
            // 
            this.customizationResetBtn.Name = "customizationResetBtn";
            this.customizationResetBtn.Size = new System.Drawing.Size(253, 26);
            this.customizationResetBtn.Text = "Customization settings";
            this.customizationResetBtn.Click += new System.EventHandler(this.customizationResetBtn_Click);
            // 
            // bookmarksResetBtn
            // 
            this.bookmarksResetBtn.Name = "bookmarksResetBtn";
            this.bookmarksResetBtn.Size = new System.Drawing.Size(253, 26);
            this.bookmarksResetBtn.Text = "Bookmarks";
            this.bookmarksResetBtn.Click += new System.EventHandler(this.bookmarksResetBtn_Click);
            // 
            // stayOnTopBtn
            // 
            this.stayOnTopBtn.CheckOnClick = true;
            this.stayOnTopBtn.CheckState = global::Violoncello.Properties.Settings.Default.stayOnTopCheckState;
            this.stayOnTopBtn.Image = ((System.Drawing.Image)(resources.GetObject("stayOnTopBtn.Image")));
            this.stayOnTopBtn.Name = "stayOnTopBtn";
            this.stayOnTopBtn.Size = new System.Drawing.Size(189, 26);
            this.stayOnTopBtn.Text = "Stay on top";
            this.stayOnTopBtn.Click += new System.EventHandler(this.stayOnTopBtn_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // urlTxt
            // 
            this.urlTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.urlTxt.BackColor = System.Drawing.Color.Black;
            this.urlTxt.Font = new System.Drawing.Font("Verdana", 12F);
            this.urlTxt.ForeColor = System.Drawing.Color.White;
            this.urlTxt.Location = new System.Drawing.Point(51, 10);
            this.urlTxt.Name = "urlTxt";
            this.urlTxt.Size = new System.Drawing.Size(371, 32);
            this.urlTxt.TabIndex = 3;
            this.urlTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlTxt_KeyDown);
            // 
            // topBtn
            // 
            this.topBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.topBtn.BackColor = System.Drawing.Color.Transparent;
            this.topBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topBtn.BackgroundImage")));
            this.topBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.topBtn.FlatAppearance.BorderSize = 0;
            this.topBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.topBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.topBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topBtn.Location = new System.Drawing.Point(849, 6);
            this.topBtn.Name = "topBtn";
            this.topBtn.Size = new System.Drawing.Size(36, 36);
            this.topBtn.TabIndex = 7;
            this.toolTip.SetToolTip(this.topBtn, "Jump to top (Ctrl+T)");
            this.topBtn.UseVisualStyleBackColor = false;
            this.topBtn.Click += new System.EventHandler(this.topBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reloadBtn.BackColor = System.Drawing.Color.Transparent;
            this.reloadBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reloadBtn.BackgroundImage")));
            this.reloadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reloadBtn.FlatAppearance.BorderSize = 0;
            this.reloadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.reloadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.reloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadBtn.Location = new System.Drawing.Point(806, 6);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(36, 36);
            this.reloadBtn.TabIndex = 6;
            this.toolTip.SetToolTip(this.reloadBtn, "Reload (Ctrl+R)");
            this.reloadBtn.UseVisualStyleBackColor = false;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(9, 6);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(36, 36);
            this.backBtn.TabIndex = 4;
            this.toolTip.SetToolTip(this.backBtn, "Back (Ctrl+B)");
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // favoritesList
            // 
            this.favoritesList.FormattingEnabled = true;
            this.favoritesList.ItemHeight = 18;
            this.favoritesList.Location = new System.Drawing.Point(528, 10);
            this.favoritesList.Name = "favoritesList";
            this.favoritesList.Size = new System.Drawing.Size(101, 22);
            this.favoritesList.TabIndex = 9;
            this.favoritesList.Visible = false;
            // 
            // bookmarkMenu
            // 
            this.bookmarkMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bookmarkMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookmarkNameBtn,
            this.toolStripSeparator2,
            this.visitBookmarkBtn,
            this.removeBookmarkBtn});
            this.bookmarkMenu.Name = "bookmarkMenu";
            this.bookmarkMenu.Size = new System.Drawing.Size(215, 88);
            // 
            // bookmarkNameBtn
            // 
            this.bookmarkNameBtn.Enabled = false;
            this.bookmarkNameBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bookmarkNameBtn.Image = ((System.Drawing.Image)(resources.GetObject("bookmarkNameBtn.Image")));
            this.bookmarkNameBtn.Name = "bookmarkNameBtn";
            this.bookmarkNameBtn.Size = new System.Drawing.Size(214, 26);
            this.bookmarkNameBtn.Text = "Bookmark URL";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(211, 6);
            // 
            // visitBookmarkBtn
            // 
            this.visitBookmarkBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.visitBookmarkBtn.Image = ((System.Drawing.Image)(resources.GetObject("visitBookmarkBtn.Image")));
            this.visitBookmarkBtn.Name = "visitBookmarkBtn";
            this.visitBookmarkBtn.Size = new System.Drawing.Size(214, 26);
            this.visitBookmarkBtn.Text = "Visit site";
            // 
            // removeBookmarkBtn
            // 
            this.removeBookmarkBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.removeBookmarkBtn.Image = ((System.Drawing.Image)(resources.GetObject("removeBookmarkBtn.Image")));
            this.removeBookmarkBtn.Name = "removeBookmarkBtn";
            this.removeBookmarkBtn.Size = new System.Drawing.Size(214, 26);
            this.removeBookmarkBtn.Text = "Remove bookmark";
            // 
            // statusPB
            // 
            this.statusPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusPB.BackColor = System.Drawing.Color.Transparent;
            this.statusPB.Image = global::Violoncello.Properties.Resources.logo;
            this.statusPB.Location = new System.Drawing.Point(428, 4);
            this.statusPB.Name = "statusPB";
            this.statusPB.Size = new System.Drawing.Size(36, 36);
            this.statusPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusPB.TabIndex = 2;
            this.statusPB.TabStop = false;
            // 
            // webView
            // 
            this.webView.AutoScroll = true;
            this.webView.AutoScrollMinSize = new System.Drawing.Size(894, 142);
            this.webView.BackColor = System.Drawing.SystemColors.Window;
            this.webView.BaseStylesheet = null;
            this.webView.Cursor = System.Windows.Forms.Cursors.Default;
            this.webView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView.Location = new System.Drawing.Point(3, 3);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(894, 413);
            this.webView.TabIndex = 10;
            this.webView.Text = "<h1>Violoncello Browser</h1><p>Created by John Spahr</p>";
            this.webView.LinkClicked += new System.EventHandler<TheArtOfDev.HtmlRenderer.Core.Entities.HtmlLinkClickedEventArgs>(this.webView_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.webView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 474);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusPB);
            this.panel1.Controls.Add(this.urlTxt);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.favoritesList);
            this.panel1.Controls.Add(this.reloadBtn);
            this.panel1.Controls.Add(this.topBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 49);
            this.panel1.TabIndex = 11;
            // 
            // fontDialog
            // 
            this.fontDialog.AllowScriptChange = false;
            this.fontDialog.Font = global::Violoncello.Properties.Settings.Default.fontPreference;
            this.fontDialog.FontMustExist = true;
            this.fontDialog.ScriptsOnly = true;
            this.fontDialog.ShowEffects = false;
            // 
            // textColorDialog
            // 
            this.textColorDialog.Color = global::Violoncello.Properties.Settings.Default.textColor;
            // 
            // backgroundColorDialog
            // 
            this.backgroundColorDialog.Color = global::Violoncello.Properties.Settings.Default.backgroundColor;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(302, 6);
            // 
            // closeBtn
            // 
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeBtn.Size = new System.Drawing.Size(305, 26);
            this.closeBtn.Text = "Close";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(918, 549);
            this.Name = "MainForm";
            this.Text = "Welcome to Violoncello!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.bookmarkMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusPB)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem bookmarksMenuItem;
        private System.Windows.Forms.PictureBox statusPB;
        private System.Windows.Forms.TextBox urlTxt;
        private System.Windows.Forms.ToolStripMenuItem bookmarkBtn;
        private System.Windows.Forms.Button backBtn;

        private Button reloadBtn;
        private Button topBtn;
        private ToolTip toolTip;
        private ListBox favoritesList;
        private ContextMenuStrip bookmarkMenu;
        private ToolStripMenuItem bookmarkNameBtn;
        private ToolStripMenuItem removeBookmarkBtn;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem visitBookmarkBtn;
        private ToolStripMenuItem toolStripMenuItem4;
        private FontDialog fontDialog;
        private ColorDialog backgroundColorDialog;
        private ColorDialog textColorDialog;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem backgroundBtn;
        private ToolStripMenuItem textColorBtn;
        private ToolStripMenuItem fontBtn;
        private ToolStripMenuItem resetBookmarksToolStripMenuItem;
        private ToolStripMenuItem customizationResetBtn;
        private ToolStripMenuItem bookmarksResetBtn;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem searchEngineBtn;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel webView;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private ToolStripMenuItem stayOnTopBtn;
        private ToolStripMenuItem browserMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
        private ToolStripMenuItem reloadToolStripMenuItem;
        private ToolStripMenuItem jumpToTopToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mainBrowserBtn;
        private ToolStripMenuItem saveBtn;
        private ToolStripMenuItem pageInfoBtn;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem closeBtn;
    }
}

