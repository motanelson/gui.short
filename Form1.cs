using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace guiSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName.Trim() != "") 
            {
                textBox1.Text=File.ReadAllText(openFileDialog1.FileName.Trim());
            
            
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName.Trim() != "") 
            {
                File.WriteAllText(saveFileDialog1.FileName.Trim(), textBox1.Text);
            
            
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                saveFileDialog1.FileName = "";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName.Trim() != "")
                {
                    File.WriteAllText(saveFileDialog1.FileName.Trim(), textBox1.Text);


                }
            }
            textBox1.Text = "";
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                saveFileDialog1.FileName = "";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName.Trim() != "")
                {
                    File.WriteAllText(saveFileDialog1.FileName.Trim(), textBox1.Text);


                }
            }
            textBox1.Text = "";
        }

        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] ss=(textBox1.Text+"\r\n").Split('\n');
            String s = "";
            Array.Sort(ss);
            foreach (var item in ss)

            {
                s = s +item+ "\n";
            }
            textBox1.Text=s; 
        }

        private void sortBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] ss = (textBox1.Text + "\r\n").Split('\n');
            String s = "";
            Array.Reverse(ss);
            foreach (var item in ss)

            {
                s = s + item + "\n";
            }
            textBox1.Text = s;

        }
    }
}
