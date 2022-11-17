namespace DiazSantiago_CourseProject_Part1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.addSongButton = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.artistBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.showAll_button = new System.Windows.Forms.Button();
            this.songList = new System.Windows.Forms.ListBox();
            this.findButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.webViewDisplay = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.playButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artist:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "URL:";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(318, 255);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(470, 183);
            this.outputBox.TabIndex = 5;
            // 
            // addSongButton
            // 
            this.addSongButton.Location = new System.Drawing.Point(44, 231);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(109, 40);
            this.addSongButton.TabIndex = 6;
            this.addSongButton.Text = "Add Song";
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click_1);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(97, 39);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(182, 20);
            this.titleBox.TabIndex = 7;
            // 
            // artistBox
            // 
            this.artistBox.Location = new System.Drawing.Point(97, 74);
            this.artistBox.Name = "artistBox";
            this.artistBox.Size = new System.Drawing.Size(182, 20);
            this.artistBox.TabIndex = 8;
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(97, 109);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(182, 20);
            this.genreBox.TabIndex = 9;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(97, 144);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(182, 20);
            this.yearBox.TabIndex = 10;
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(97, 179);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(182, 20);
            this.urlBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Details:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Song List:";
            // 
            // showAll_button
            // 
            this.showAll_button.Location = new System.Drawing.Point(44, 277);
            this.showAll_button.Name = "showAll_button";
            this.showAll_button.Size = new System.Drawing.Size(109, 40);
            this.showAll_button.TabIndex = 15;
            this.showAll_button.Text = "Show All Songs";
            this.showAll_button.UseVisualStyleBackColor = true;
            this.showAll_button.Click += new System.EventHandler(this.showAll_button_Click);
            // 
            // songList
            // 
            this.songList.FormattingEnabled = true;
            this.songList.Location = new System.Drawing.Point(320, 43);
            this.songList.Name = "songList";
            this.songList.Size = new System.Drawing.Size(470, 173);
            this.songList.TabIndex = 16;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(159, 231);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(109, 40);
            this.findButton.TabIndex = 17;
            this.findButton.Text = "Find Song";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(159, 277);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(109, 40);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // webViewDisplay
            // 
            this.webViewDisplay.AllowExternalDrop = true;
            this.webViewDisplay.CreationProperties = null;
            this.webViewDisplay.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewDisplay.Location = new System.Drawing.Point(816, 43);
            this.webViewDisplay.Name = "webViewDisplay";
            this.webViewDisplay.Size = new System.Drawing.Size(312, 349);
            this.webViewDisplay.Source = new System.Uri("https://www.microsoft.com", System.UriKind.Absolute);
            this.webViewDisplay.TabIndex = 19;
            this.webViewDisplay.ZoomFactor = 1D;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(816, 398);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(109, 40);
            this.playButton.TabIndex = 20;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 450);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.webViewDisplay);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.showAll_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.artistBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.addSongButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 1500);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.Text = "Video Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button addSongButton;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox artistBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button showAll_button;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button clearButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewDisplay;
        private System.Windows.Forms.Button playButton;
    }
}

