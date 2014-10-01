using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        int n = 3;
        Button close = new Button();
        Label zakon = new Label();
        TextBox[] koordinata;
        TextBox[] skorost;
        TextBox[] uskorenie;
        Button prov=new Button();
        public Form1()
        {
            koordinata = new TextBox[n];
            skorost = new TextBox[n];
            uskorenie = new TextBox[n];

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(close);
            close.Text = "Выход";
            close.Location = new Point(424, 327);
            this.CancelButton = close;
            close.Click += new EventHandler(close_click);
        }
        private void close_click(object sender, EventArgs e)
        {
            Close();
        }
        private void prov_click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Controls.Add(zakon);
            zakon.Size = new Size(150, 30);
            zakon.Text = "Закон движения:\r\nX=3t^3+4t^2+10";
            zakon.Location = new Point(240, 10);

            for (int i = 0; i < n; i++)
            {
                koordinata[i] = new TextBox();
                this.Controls.Add(koordinata[i]);
                koordinata[i].Size = new Size(68, 20);
                koordinata[i].Location = new Point(150 + (70 * i), 100);
            }
            for (int i = 0; i < n; i++)
            {
                skorost[i] = new TextBox();
                this.Controls.Add(skorost[i]);
                skorost[i].Size = new Size(68, 20);
                skorost[i].Location = new Point(150 + (70 * i), 122);
            }
            for (int i = 0; i < n; i++)
            {
                uskorenie[i] = new TextBox();
                this.Controls.Add(uskorenie[i]);
                uskorenie[i].Size = new Size(68, 20);
                uskorenie[i].Location = new Point(150 + (70 * i), 144);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.Controls.Add(prov);
            prov.Text = "Проверка";
            prov.Location = new Point(424, 297);
            this.CancelButton = close;
            prov.Click += new EventHandler(prov_click);

            this.Controls.Add(zakon);
            zakon.Size = new Size(150, 30);
            zakon.Text = "Закон движения:\r\nX=3t^3+4t^2+10";
            zakon.Location = new Point(240, 10);

            for (int i = 0; i < n; i++)
            {
                koordinata[i] = new TextBox();
                this.Controls.Add(koordinata[i]);
                koordinata[i].Size = new Size(68, 20);
                koordinata[i].Location = new Point(150 + (70 * i), 100);
            }
            for (int i = 0; i < n; i++)
            {
                skorost[i] = new TextBox();
                this.Controls.Add(skorost[i]);
                skorost[i].Size = new Size(68, 20);
                skorost[i].Location = new Point(150 + (70 * i), 122);
            }
            for (int i = 0; i < n; i++)
            {
                uskorenie[i] = new TextBox();
                this.Controls.Add(uskorenie[i]);
                uskorenie[i].Size = new Size(68, 20);
                uskorenie[i].Location = new Point(150 + (70 * i), 144);
            }
        }

    }

}
