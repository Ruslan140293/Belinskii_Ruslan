using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.symbol =textBox1.Text;
            if (Form1.symbol.Length == 0) { Form1.symbol = "`"; }
        }
    }
}
