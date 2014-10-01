using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           label3.Text = "Закон Движения\nX=" +
                    Convert.ToString(Math.Round(Math.PI * hScrollBar1.Value * hScrollBar2.Value, 2)) +
                    "*cos(" +
                    Convert.ToString(Math.Round(Math.PI * hScrollBar2.Value, 2)) + "*t)\nY=" +
                    Convert.ToString(Math.Round(Math.PI * hScrollBar1.Value * hScrollBar2.Value, 2)) +
                    "*sin(" +
                    Convert.ToString(Math.Round(Math.PI * hScrollBar2.Value, 2)) + "*t)";
            textBox1.Text = Convert.ToString(hScrollBar1.Value*(Math.PI*Math.PI)*(hScrollBar2.Value*hScrollBar2.Value));
            textBox2.Text = Convert.ToString(hScrollBar1.Value*Math.Pow(Math.PI,3)*Math.Pow(hScrollBar2.Value,3));
                }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label3.Text = "Закон Движения\nX=" +
                    Convert.ToString(Math.Round(Math.PI * hScrollBar1.Value * hScrollBar2.Value, 2)) +
                    "*cos(" +
                    Convert.ToString(Math.Round(Math.PI * hScrollBar2.Value, 2)) + "*t)\nY=" +
                    Convert.ToString(Math.Round(Math.PI * hScrollBar1.Value * hScrollBar2.Value, 2)) +
                    "*sin(" +
                    Convert.ToString(Math.Round(Math.PI * hScrollBar2.Value, 2)) + "*t)";
            textBox1.Text = Convert.ToString(hScrollBar1.Value*hScrollBar2.Value);
            textBox2.Text = Convert.ToString(hScrollBar1.Value*hScrollBar2.Value*hScrollBar2.Value);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "Закон Движения\nX=PI*a*w*cos(PI*w*t)\nY=PI*a*w*sin(PI*w*t)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = !textBox1.Visible;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Visible = !textBox2.Visible;
        }
    }
}
