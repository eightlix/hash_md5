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
using MyMD5;
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
                        hashedText.Text = MyMD5.MyMD5.GetHash(sr.ToString());
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
                    hashedText.Text = MyMD5.MyMD5.GetHash(sourceText.Text);
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
                label2.Text = $"the path is: {ofd.FileName}";
                sourceText.Enabled = false;
                sourceText.Text = "click restore path to be able to write here";
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            sourceText.Text = "";
            label2.Text = "the path is: none";
            path = "path";
            sourceText.Enabled = true;
        }
    }
}
