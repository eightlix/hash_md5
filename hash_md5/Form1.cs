using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hash_md5;
using System.IO;
using MyHash;

namespace hash_md5

{
	public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path = "path";

        private void getHash_Click(object sender, EventArgs e)
        {
            
            if(path != "path")
            {
                try
                {
                    using(StreamReader sr = new StreamReader(path))
                    {
                        hashedText.Text = MyHash.MyMD5.GetHash(sr.ToString());
                        copy.Enabled = true;
                        copy.BackColor = Color.FromArgb(83, 79, 213);
                        copy.Text = "Copy";
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("the file cannot be opened. it may be using by another proces");
                }
            }
            else
            {
                if(sourceText.Text == "")
                {
                    MessageBox.Show("you neither writed a text nor chosen a file");
                }
                else
                {
                    copy.BackColor = Color.FromArgb(83, 79, 213);
                    copy.Text = "Copy";
                    hashedText.Text = MyHash.MyMD5.GetHash(sourceText.Text);
                    copy.Enabled = true;
                }
            }
            
        }

        private void file_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text|*.txt|All|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                pathOfFile.Text = $"the path is: ";
                pathOfFile.AppendText(path, Color.FromArgb(255, 82, 159));
                sourceText.ReadOnly = true;
                sourceText.Text = "click ";
                sourceText.AppendText("reset", Color.FromArgb(255, 82, 159));
                sourceText.AppendText(" to be able to write here");
                
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            sourceText.Text = "";
            pathOfFile.Text = "the path is: ";
            pathOfFile.AppendText("none", Color.FromArgb(255, 82, 159));
            path = "path";
            sourceText.ReadOnly = false;
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(hashedText.Text);
            copy.BackColor = Color.FromArgb(0, 204, 106);
            copy.ForeColor = Color.Black;
            copy.Text = "Copied";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            copy.Enabled = false;
            hashedText.ReadOnly = true;
            hashedText.ReadOnly = true;
            pathOfFile.ReadOnly = true;
            hashedText.TextAlign = HorizontalAlignment.Center;
            close.FlatAppearance.BorderSize = 0;
            close.FlatStyle = FlatStyle.Flat;

            pathOfFile.Text = "the path is: ";
            pathOfFile.AppendText("none", Color.FromArgb(255, 82, 159));


        }

        



        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor = Color.FromArgb(255, 82, 159);
        }
        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.FromArgb(48, 49, 58);
        }

        
    }
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
