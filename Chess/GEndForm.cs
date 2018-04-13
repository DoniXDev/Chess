using System;
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

        private void GEndForm_Load(object sender, EventArgs e)
        {
            
            Point p = new Point();
            p.X = mainform.Location.X + (300 - 250/2);
            p.Y = mainform.Location.Y + (150 - 135/2);

            this.Location = p;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
