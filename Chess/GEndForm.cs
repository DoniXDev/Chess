﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class GEndForm : Form
    {
        MainForm mainform;


        public GEndForm(MainForm a)
        {
            InitializeComponent();
            mainform = a;
        }

        //Close
        private void ExitButton_Click(object sender, EventArgs e)
        {
            mainform.Invoke((MethodInvoker)(() => this.Enabled = false));
            Close();
        }

        //SETPOSITION
        public void SetPosition()
        {
            Point p = new Point();
            p.X = mainform.Location.X + (300 - 250 / 2);
            p.Y = mainform.Location.Y + (150 - 135 / 2);

            this.Location = p;
        }

        //WIN
        public void Win(int a)
        {
            mainform.Invoke((MethodInvoker)(() => WLLabel.ForeColor = Color.DarkGreen));
            mainform.Invoke((MethodInvoker)(() => WLLabel.Text = "WIN"));
            mainform.Invoke((MethodInvoker)(() => LPLabel.Text = "|+" + a.ToString() + "|"));
            mainform.Invoke((MethodInvoker)(() => GoldLabel.Text = "+50 gold"));
            mainform.Invoke((MethodInvoker)(() => SetPosition()));
            mainform.Invoke((MethodInvoker)(() => this.Enabled = true));
            mainform.Invoke((MethodInvoker)(() => this.Show()));
        }

        //LOSE
        public void Lose()
        {
            mainform.Invoke((MethodInvoker)(() => WLLabel.ForeColor = Color.Maroon));
            mainform.Invoke((MethodInvoker)(() => WLLabel.Text = "LOSE"));
            mainform.Invoke((MethodInvoker)(() => LPLabel.Text = ""));
            mainform.Invoke((MethodInvoker)(() => GoldLabel.Text = "+10 gold"));
            mainform.Invoke((MethodInvoker)(() => SetPosition()));
            mainform.Invoke((MethodInvoker)(() => this.Enabled = true));
            mainform.Invoke((MethodInvoker)(() => this.Show()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://donixdev.esy.es/chess/index.php?page=profile&name=" + mainform.PlayerOne.Name);
        }
    }
}
