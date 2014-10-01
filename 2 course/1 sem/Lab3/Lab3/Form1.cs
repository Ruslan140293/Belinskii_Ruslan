using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        static public string symbol = "", symbol_zam = "";
        public Form1()
        {
            InitializeComponent();             
        }

        public void SortVoz(string[] masStr)
        {
            string s = "";
            for (int i = 0; i < masStr.Length - 1; i++)
                for (int j = 0; j < masStr.Length - i - 1; j++)
                    if (masStr[j].Length > masStr[j + 1].Length)
                    {
                        s = masStr[j];
                        masStr[j] = masStr[j + 1];
                        masStr[j + 1] = s;
                    }
        }

        public string isk(string str)
        {
            string buf1 = "", buf2 = "";            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == Convert.ToChar(symbol) )
                {
                    for (int j = 0; j < i; j++)
                    {
                        buf1 += Convert.ToString(str[j]);
                    }
                    for (int j = i+1; j < str.Length; j++)
                    {
                        buf2 += Convert.ToString(str[j]);
                    }
                    str = buf1 + buf2;
                    buf1 = ""; buf2 = "";
                    i--;
                }
            }
            return str;
        }

        public string zam(string str)
        {
            string buf1 = "", buf2 = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == Convert.ToChar(symbol))
                {
                    for (int j = 0; j < i; j++)
                    {
                        buf1 += Convert.ToString(str[j]);
                    }
                    buf1 += Convert.ToString(symbol_zam);
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        buf2 += Convert.ToString(str[j]);
                    }
                    str = buf1 + buf2;
                    buf1 = ""; buf2 = "";
                }
            }
            return str;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void исключитьСимволToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            Form2 f2 = new Form2();
            f2.ShowDialog();
            str = isk(str);
            textBox2.Text=str;
        }

        private void заменитьСимволToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            zam(str);
            Form3 f3 = new Form3();
            f3.ShowDialog();
            str = zam(str);
            textBox2.Text = str;
        }

        private void наибольшееСловоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char[] sep = { ' ', ',', '.', '\r', '\n', '\t' };
            string str = textBox1.Text;
            if (str.Length != 0)
            {
                string[] masStr = str.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                SortVoz(masStr);
                textBox2.Text = masStr[masStr.Length - 1];
            }
        }

        private void вПорядкеВозрастанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char[] sep = { ' ', ',', '.', '\r', '\n', '\t' };
            string str = textBox1.Text;
            string[] masStr = str.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            SortVoz(masStr);
            str = "";
            for (int i=0;i<masStr.Length;i++)
            {
                str += masStr[i] + "\r\n";
            }
            textBox2.Text = str;
        }

        private void наименьшееСловоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char[] sep = { ' ', ',', '.', '\r', '\n', '\t' };
            string str = textBox1.Text;
            if (str.Length != 0)
            {
                string[] masStr = str.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                SortVoz(masStr);
                textBox2.Text = masStr[0];
            }
        }

        private void вПорядкеУбыванияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char[] sep = { ' ', ',', '.', '\r', '\n', '\t' };
            string str = textBox1.Text;
            string[] masStr = str.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            SortVoz(masStr);
            str = "";
            for (int i = masStr.Length-1; i>=0; i--)
            {
                str += masStr[i] + "\r\n";
            }
            textBox2.Text = str;
        }
    }
}
