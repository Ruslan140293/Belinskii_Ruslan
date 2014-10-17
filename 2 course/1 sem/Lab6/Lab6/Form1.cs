using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Lab6
{
    public partial class Form1 : Form
    {
        DirectoryInfo dir = new DirectoryInfo(@"D:\git_study\2 course\1 sem\Lab6\Lab6\bin\Debug");
        public static string NameOfFile = "";
        public static string folder_ = "";
        private string adress = "";
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                NameOfFile = openFileDialog1.FileName;
                if (openFileDialog1.FilterIndex == 1)
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                else
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                label1.Text = openFileDialog1.FileName;
                adress = openFileDialog1.FileName;
            }
        }

        private void вТекущемКатологеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Form open = new Form2();
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(NameOfFile))
                {
                    MessageBox.Show("Существует");
                }
                else
                {
                    StreamWriter sw = new StreamWriter(NameOfFile, false);
                    sw.Close();
                    label1.Text = dir.ToString() + "\\" + NameOfFile;
                    adress = dir.ToString() + "\\" + NameOfFile;
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NameOfFile.Length != 0)
            {
                if (NameOfFile.Substring(NameOfFile.Length - 3) == "rtf")
                    richTextBox1.SaveFile(adress);
                else
                    richTextBox1.SaveFile(adress, RichTextBoxStreamType.PlainText);
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    NameOfFile = saveFileDialog1.FileName;
                    if (NameOfFile.Substring(NameOfFile.Length - 3) == "rtf")
                    {
                        richTextBox1.SaveFile(NameOfFile);
                        adress = saveFileDialog1.FileName;
                    }
                    else
                    {
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        adress = saveFileDialog1.FileName;
                    }
                    label1.Text = saveFileDialog1.FileName;
                }

            }
        }

        private void вИмеющемсяКатологеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Form open = new Form2();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(folderBrowserDialog1.SelectedPath + "\\" + NameOfFile))
                    {
                        MessageBox.Show("Существует");
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter(folderBrowserDialog1.SelectedPath + "\\" + NameOfFile, false);
                        sw.Close();
                        label1.Text = folderBrowserDialog1.SelectedPath + "\\" + NameOfFile;
                        adress = folderBrowserDialog1.SelectedPath + "\\" + NameOfFile;
                    }
                }
            }
        }

        private void вНовомКатологеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Form3 folder = new Form3();
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo dir1 = new DirectoryInfo(folderBrowserDialog1.SelectedPath + "\\" + folder_);
                    dir1.Create();
                    Form open = new Form2();
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(folderBrowserDialog1.SelectedPath + "\\" + folder_ + "\\" + NameOfFile))
                        {
                            MessageBox.Show("Существует");
                        }
                        else
                        {
                            StreamWriter sw = new StreamWriter(folderBrowserDialog1.SelectedPath + "\\" + folder_ + "\\" + NameOfFile, false);
                            sw.Close();
                            label1.Text = folderBrowserDialog1.SelectedPath + "\\" + folder_ + "\\" + NameOfFile;
                            adress = folderBrowserDialog1.SelectedPath + "\\" + folder_ + "\\" + NameOfFile;
                        }
                    }
                }
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog1.Color;
        }

    }
}
