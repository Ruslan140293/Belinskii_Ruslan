using System;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            numericUpDown1.Value = Form1._t;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1._t = Convert.ToInt32(numericUpDown1.Value);
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
