using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Chess
{
    public partial class NameInput : Form
    {
        MainForm mainform;

        public NameInput(MainForm a)
        {
            InitializeComponent();
            mainform = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text.Length < 8 )
            {
                mainform.EnterPlayerName(textBox1.Text);
                File.WriteAllText(@"ChessFigures\a.name", textBox1.Text);
                this.Close();
            }
        }
    }
}
