using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        string font = "Microsoft Sans Serif";
        int size=8;
        Color col = Color.Black;
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            { цветToolStripMenuItem.Enabled = true; }
            else
            {
                цветToolStripMenuItem.Enabled = false; 
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            { шрифтToolStripMenuItem.Enabled = true; }
            else { шрифтToolStripMenuItem.Enabled = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            { размерToolStripMenuItem.Enabled = true; }
            else { размерToolStripMenuItem.Enabled = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            }
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.Font = new Font("Microsoft Sans Serif", 8);
            radioButton2.Font = new Font("Microsoft Sans Serif", 8);
            radioButton3.Font = new Font("Microsoft Sans Serif", 8);
            radioButton1.Visible = true;
            radioButton1.Text = "Красный";
            radioButton1.ForeColor = Color.Red;
            radioButton2.Visible = true;
            radioButton2.ForeColor = Color.Blue;
            radioButton2.Text = "Синий";
            radioButton3.ForeColor = Color.Green;
            radioButton3.Visible = true;
            radioButton3.Text = "Зеленый";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Black;
            radioButton3.ForeColor = Color.Black;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton1.Text = "Sans Serif";
            radioButton1.Font = new Font("Microsoft Sans Serif", 8);
            radioButton2.Text = "Comic Sans MS";
            radioButton2.Font = new Font("Comic Sans MS", 8);
            radioButton3.Text = "Times New Roman";
            radioButton3.Font = new Font("Times New Roman", 8);
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void размерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Black;
            radioButton3.ForeColor = Color.Black;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton1.Font = new Font("Microsoft Sans Serif", 8);
            radioButton2.Font = new Font("Microsoft Sans Serif", 10);
            radioButton3.Font = new Font("Microsoft Sans Serif", 12);
            radioButton1.Text = "8";
            radioButton2.Text = "10";
            radioButton3.Text = "12";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Text == "Красный")
                col = Color.Red;
            if (radioButton1.Text == "Sans Serif")
                font="Microsoft Sans Serif";
            if (radioButton1.Text == "8")
                size = 8;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Text == "Синий")
                col = Color.Blue;
            if (radioButton2.Text == "Comic Sans MS")
                font="Comic Sans MS";
            if (radioButton2.Text == "10")
                size=10;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Text == "Зеленый")
                col = Color.Green;
            if (radioButton3.Text == "Times New Roman")
                font="Times New Roman";
            if (radioButton3.Text == "12")
                size=12;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Font = new Font(font,size);
            label1.ForeColor = col;            
        }
    }
}
