using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
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
        if (textBox1.Text.Length != 0 && comboBox1.Text.Length != 0)
        {
            Form1.name=textBox1.Text;
            Form1.rasw = comboBox1.Text;
            Close(); 
        }
        else
            MessageBox.Show("Пустые поля");
    }
  }
}
