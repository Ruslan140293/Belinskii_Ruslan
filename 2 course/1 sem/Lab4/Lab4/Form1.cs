using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox1.MouseMove += new MouseEventHandler(Form1_MouseMove);
            groupBox1.MouseDown += new MouseEventHandler(Form1_MouseDown);
            groupBox1.MouseUp += new MouseEventHandler(Form1_MouseUp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox6.Text = textBox6.Text + "\r\nБыла нажата клавиша:" + Convert.ToString(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox6.Text = textBox6.Text + "\r\nБыла нажата клавиша:" + Convert.ToString(e.KeyChar);
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                e.Handled = true;
                MessageBox.Show("Какое-то из полей пустое!!!");
            }
            else
                if (e.KeyChar == Convert.ToChar(textBox1.Text))
                {
                    e.KeyChar = Convert.ToChar(textBox2.Text);
                }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Enabled = !label4.Enabled;
            if (textBox3.Text.Length != 0)
            {
                timer1.Enabled = false;
                label4.Enabled = true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox4.Text = Convert.ToString(e.X);
            textBox5.Text = Convert.ToString(e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox4.Text = Convert.ToString(e.X + label1.Location.X);
            textBox5.Text = Convert.ToString(e.Y + label1.Location.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox4.Text = Convert.ToString(e.X + panel1.Location.X);
            textBox5.Text = Convert.ToString(e.Y + panel1.Location.Y);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            textBox4.Text = Convert.ToString(e.X + panel1.Location.X + label2.Location.X);
            textBox5.Text = Convert.ToString(e.Y + panel1.Location.Y + label2.Location.Y);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            textBox4.Text = Convert.ToString(e.X + panel1.Location.X + label3.Location.X);
            textBox5.Text = Convert.ToString(e.Y + panel1.Location.Y + label3.Location.Y);
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            textBox4.Text = Convert.ToString(e.X + panel1.Location.X + label4.Location.X);
            textBox5.Text = Convert.ToString(e.Y + panel1.Location.Y + label4.Location.Y);
        }

        private void textBox3_MouseMove(object sender, MouseEventArgs e)
        {
            textBox4.Text = Convert.ToString(e.X + panel1.Location.X + textBox3.Location.X);
            textBox5.Text = Convert.ToString(e.Y + panel1.Location.Y + textBox3.Location.Y);
        }

        private void textBox2_MouseMove(object sender, MouseEventArgs e)
        {
            textBox4.Text = Convert.ToString(e.X + panel1.Location.X + textBox2.Location.X);
            textBox5.Text = Convert.ToString(e.Y + panel1.Location.Y + textBox2.Location.Y);
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox4.Text = Convert.ToString(e.X + panel1.Location.X + textBox1.Location.X);
            textBox5.Text = Convert.ToString(e.Y + panel1.Location.Y + textBox1.Location.Y);
        }

        private void textBox6_MouseMove(object sender, MouseEventArgs e)
        {
            textBox4.Text = Convert.ToString(e.X + textBox6.Location.X);
            textBox5.Text = Convert.ToString(e.Y + textBox6.Location.Y);
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox4.Text = Convert.ToString(e.X + button1.Location.X);
            textBox5.Text = Convert.ToString(e.Y + button1.Location.Y);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                checkBox1.Checked = true;
            if (e.Button == MouseButtons.Right)
                checkBox2.Checked = true;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                checkBox1.Checked = false;
            if (e.Button == MouseButtons.Right)
                checkBox2.Checked = false;
        }
    }
}