using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiazSantiago_CourseProject_Part1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

            if (string.IsNullOrEmpty(titleBox.Text))
            {
                MessageBox.Show("The song title cannot be blank");
            }
            else if (string.IsNullOrEmpty(artistBox.Text))
            {
                MessageBox.Show("The artist cannot be blank");
            }
            else
            {
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
            string n1 = "\r\n";

            foreach(var item in songList.Items)
            {
                sb.Append(item.ToString());
                sb.Append(n1);
            }

            outputBox.Text = sb.ToString();
        }
    }
}
