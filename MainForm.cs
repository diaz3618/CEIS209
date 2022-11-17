using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using Microsoft.Web.WebView2.Core;

namespace DiazSantiago_CourseProject_Part1
{
    public partial class MainForm : Form
    {
        // Class level references
        string[] titleArray = new string[5];
        string[] artistArray = new string[5];
        string[] genreArray = new string[5];
        int[] yearArray = new int[5];
        string[] urlArray = new string[5];
        int songCount = 0;

        private bool SongInList(string SongTitle)
        {
            bool inList = false;
            foreach (string currentSong in songList.Items)
            {
                if (SongTitle == currentSong)
                {
                    inList = true;
                    //Break out of loop
                    break;
                }
            }
            //Return Result
            return inList;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private bool ValidInput()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(titleBox.Text))
            {
                // Title is blank
                MessageBox.Show("The song title cannot be blank");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(artistBox.Text))
            {
                MessageBox.Show("The artist cannot be blank");
                isValid = false;
            }

            return isValid;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addSongButton_Click_1(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputBox.Text);
            string n1 = "\r\n";

            if (songCount == titleArray.Length)
            {
                MessageBox.Show("Song list is full");
            }
            else if (ValidInput())
            {
                songList.Items.Add(titleBox.Text);
                titleArray[songCount]   = titleBox.Text;
                artistArray[songCount]  = artistBox.Text;
                genreArray[songCount]   = genreBox.Text;
                yearArray[songCount]    = int.Parse(yearBox.Text);
                urlArray[songCount]     = urlBox.Text;

                // Increment
                songCount++;

                sb.Append(titleBox.Text);
                sb.Append(n1);
                sb.Append(artistBox.Text);
                sb.Append(n1);
                sb.Append(genreBox.Text);
                sb.Append(n1);
                sb.Append(yearBox.Text);
                sb.Append(n1);
                sb.Append(urlBox.Text);
                sb.Append(n1);
                sb.Append(n1);

                // Output box
                outputBox.Text = sb.ToString();
            }
            
        }

        private void showAll_button_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(string.Empty);

            //Shortcut for New Line
            string nl = "\r\n";

            //Build the Output Text
            foreach (var item in songList.Items)
            {
                sb.Append(item.ToString());
                sb.Append(nl);
            }
            //Put the output text into the output box
            outputBox.Text = sb.ToString();
        }

        private int GetSongIndex(string songTitle)
        {
            int songIndex = songList.Items.IndexOf(songTitle);
            return songIndex;
        }
        //*******************************
        //*****Selected Song Function****
        //*******************************
        private void songList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int songIndex = songList.SelectedIndex;

            StringBuilder sb = new StringBuilder(String.Empty);
            string nl = "\r\n";

            //Build the output Text
            sb.Append(titleArray[songIndex]);
            sb.Append(nl);
            sb.Append(artistArray[songIndex]);
            sb.Append(nl);
            sb.Append(genreArray[songIndex]);
            sb.Append(nl);
            sb.Append(yearArray[songIndex]);
            sb.Append(nl);
            sb.Append(urlArray[songIndex]);
            sb.Append(nl);

            //Output built text
            outputBox.Text = sb.ToString();
        }

        private void MB(string Text, String Title, MessageBoxIcon ICON)
        {
            MessageBox.Show(Text, Title, MessageBoxButtons.OKCancel, ICON);
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            //Create messagebox is song is found/not found.
            if (SongInList(titleBox.Text))
            {
                int songIndex = GetSongIndex(titleBox.Text);

                StringBuilder sb = new StringBuilder(String.Empty);
                string nl = "\r\n";

                //Build the output Text
                sb.Append(titleArray[songIndex]);
                sb.Append(nl);
                sb.Append(artistArray[songIndex]);
                sb.Append(nl);
                sb.Append(genreArray[songIndex]);
                sb.Append(nl);
                sb.Append(yearArray[songIndex]);
                sb.Append(nl);
                sb.Append(urlArray[songIndex]);
                sb.Append(nl);

                //Output built text
                outputBox.Text = sb.ToString();
            }
            else
            {
                MB($"Song {titleBox.Text} not found", "Error!", MessageBoxIcon.Error);
            }
        }

        private void clear()
        {
            //Clears Text
            titleBox.Clear();
            artistBox.Clear();
            genreBox.Clear();
            yearBox.Clear();
            urlBox.Clear();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int songIndex = songList.SelectedIndex;
            string url = urlArray[songIndex];
            webViewDisplay.CoreWebView2.Navigate(url);
        }
    }
}
