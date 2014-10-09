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
        static public int _t = 1;
        int n = 3;
        Button close = new Button();
        Label zakon = new Label();
        Label[] t;
        Label[] name;
        TextBox[] koordinata;
        TextBox[] skorost;
        TextBox[] uskorenie;
        Button button = new Button();
        ToolTip tip = new ToolTip();
        public Form1()
        {
            koordinata = new TextBox[n];
            skorost = new TextBox[n];
            uskorenie = new TextBox[n];
            t = new Label[n];
            name = new Label[n];

            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(close);
            close.Text = "Выход";
            close.Location = new Point(330, 327);
            this.CancelButton = close;
            close.Click += new EventHandler(close_click);
            this.Controls.Add(button);
            button.Text = "Расчет";
            button.Location = new Point(330, 270);
            this.CancelButton = close;
            button.Click += new EventHandler(button_click);
            this.Controls.Add(zakon);
            zakon.Size = new Size(150, 30);
            zakon.Text = "Закон движения:\r\nX=3t^3+4t^2+10";
            zakon.Location = new Point(200, 10);
            for (int i = 0; i < n; i++)
            {
                koordinata[i] = new TextBox();
                this.Controls.Add(koordinata[i]);
                koordinata[i].Size = new Size(68, 20);
                koordinata[i].Location = new Point(150 + (70 * i), 100);
                koordinata[i].Enabled = false;
                skorost[i] = new TextBox();
                this.Controls.Add(skorost[i]);
                skorost[i].Size = new Size(68, 20);
                skorost[i].Location = new Point(150 + (70 * i), 122);
                skorost[i].Enabled = false;
                uskorenie[i] = new TextBox();
                this.Controls.Add(uskorenie[i]);
                uskorenie[i].Size = new Size(68, 20);
                uskorenie[i].Location = new Point(150 + (70 * i), 144);
                uskorenie[i].Enabled = false;
                t[i] = new Label();
                this.Controls.Add(t[i]);
                t[i].Text = "t=" + i*_t;
                t[i].Size=new Size(30,30);
                t[i].Location = new Point(170+(i*70),85);
                name[i] = new Label();
                this.Controls.Add(name[i]);
                name[i].Text = "";
                name[i].Size = new Size(70, 13);
                name[i].Location = new Point(80, 105 + (i * 20));
            }
            name[0].Text = "Координата:";
            name[1].Text = "Скорость:";
            name[2].Text = "Ускорение:";
            t[0].Click+=new EventHandler(t_click);
            t[1].Click+=new EventHandler(t_click);
            t[2].Click+=new EventHandler(t_click);
        }
        private void t_click(object sender, EventArgs e)
        {
            Form2 f2=new Form2();
            f2.ShowDialog();            
                for (int i = 0; i < n; i++)
                {
                    t[i].Text = "t=" + i*_t;
                }
             button_click(sender,e);            
        }
        private void close_click(object sender, EventArgs e)
        {
            Close();
        }
        private void button_click(object sender, EventArgs e)
        {
            if (button.Text == "Расчет")
            {
                for (int i = 0; i < n; i++)
                {
                    koordinata[i].Text = Convert.ToString(3*Math.Pow(i*_t, 3) + 4*Math.Pow(i*_t,2) + 10);
                    skorost[i].Text = Convert.ToString((i*_t)*(9*(i*_t)+8));
                    uskorenie[i].Text = Convert.ToString(18*(i*_t) + 8);
                }
            }
            else
            {             
                for (int i = 0; i < n; i++)
                {
                    if (koordinata[i].Text != Convert.ToString(3*Math.Pow(i*_t, 3) + 4*Math.Pow(i*_t, 2) + 10))
                    {
                        koordinata[i].BackColor=Color.Red;
                    }
                    if (skorost[i].Text != Convert.ToString((i*_t)*(9*(i*_t)+8)))
                    {
                        skorost[i].BackColor = Color.Red;
                    }
                    if (uskorenie[i].Text != Convert.ToString(18 * (i * _t) + 8))
                    {
                        uskorenie[i].BackColor = Color.Red;
                    }
                }
            }
        }
        private void radioButton1_Click(object sender, EventArgs e)
        {
            button.Text = "Расчет";
            for (int i = 0; i < n; i++)
            {
                koordinata[i].Enabled = false;
                skorost[i].Enabled = false;
                uskorenie[i].Enabled = false;
                koordinata[i].BackColor = Color.White;
                skorost[i].BackColor = Color.White;
                uskorenie[i].BackColor = Color.White;
                koordinata[i].Clear();
                skorost[i].Clear();
                uskorenie[i].Clear();
            }
        }
        private void radioButton2_Click(object sender, EventArgs e)
        {
            button.Text = "Проверка";
            tip.AutomaticDelay = 300;
            for (int i = 0; i < n; i++)
            {
                koordinata[i].Enabled = true;
                skorost[i].Enabled = true;
                uskorenie[i].Enabled = true;
                koordinata[i].Clear();
                skorost[i].Clear();
                uskorenie[i].Clear();
                tip.SetToolTip(koordinata[i], "3t^3+4t^2+10");
                tip.SetToolTip(skorost[i], "t(9t+8)");
                tip.SetToolTip(uskorenie[i], "18t+8");
            }
        }
    }
}
