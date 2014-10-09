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
  public partial class Form1 : Form
  {
      static public string name = "";
      static public string rasw = "";
    public Form1()
    {
      InitializeComponent();
    }

    private void выходToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
    {
        openFileDialog1.ShowDialog();
    }

    private void вТекущемКатологеToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Form open = new Form2();
        open.ShowDialog();
        if (open.ShowDialog() == DialogResult.OK)
        {

        }
    }
  }
}
