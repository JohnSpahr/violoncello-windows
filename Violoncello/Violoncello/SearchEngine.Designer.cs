namespace Violoncello
{
    partial class SearchEngine
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
            this.okBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.queryTxt = new System.Windows.Forms.TextBox();
            this.searchEngineBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.okBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.ForeColor = System.Drawing.Color.Black;
            this.okBtn.Location = new System.Drawing.Point(157, 194);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(136, 33);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "&OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.queryTxt);
            this.groupBox1.Controls.Add(this.searchEngineBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Engine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose a search engine:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search engine query URL:";
            // 
            // queryTxt
            // 
            this.queryTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Violoncello.Properties.Settings.Default, "query", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.queryTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.queryTxt.Location = new System.Drawing.Point(7, 121);
            this.queryTxt.Name = "queryTxt";
            this.queryTxt.Size = new System.Drawing.Size(268, 27);
            this.queryTxt.TabIndex = 1;
            this.queryTxt.Text = global::Violoncello.Properties.Settings.Default.query;
            this.queryTxt.TextChanged += new System.EventHandler(this.queryTxt_TextChanged);
            // 
            // searchEngineBox
            // 
            this.searchEngineBox.BackColor = System.Drawing.Color.White;
            this.searchEngineBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchEngineBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchEngineBox.FormattingEnabled = true;
            this.searchEngineBox.Items.AddRange(new object[] {
            "Bing",
            "Google",
            "DuckDuckGo",
            "Wikipedia",
            "Custom"});
            this.searchEngineBox.Location = new System.Drawing.Point(7, 52);
            this.searchEngineBox.Name = "searchEngineBox";
            this.searchEngineBox.Size = new System.Drawing.Size(268, 28);
            this.searchEngineBox.TabIndex = 0;
            this.searchEngineBox.SelectedIndexChanged += new System.EventHandler(this.searchEngineBox_SelectedIndexChanged);
            // 
            // SearchEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 239);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.okBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchEngine";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Engine Picker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SearchEngine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox searchEngineBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox queryTxt;
    }
}