using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.symbol_zam = textBox1.Text;
            Form1.symbol = textBox2.Text;
            if (Form1.symbol.Length == 0) { Form1.symbol = "`"; }
            if (Form1.symbol_zam.Length == 0) { Form1.symbol_zam = "`"; }
        }
    }
}
