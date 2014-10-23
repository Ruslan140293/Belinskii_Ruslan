using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void теоритическиеВопросыToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form2 teorVopr = new Form2();
      teorVopr.MdiParent = this;
      teorVopr.Show();
    }

    private void практическиеВопросыToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form3 prakVopr = new Form3();
      prakVopr.MdiParent = this;
      prakVopr.Show();
    }
  }
}
