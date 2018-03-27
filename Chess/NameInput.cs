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
using System.Net;
using System.Security.Cryptography;

namespace Chess
{
    public partial class NameInput : Form
    {
        //http://localhost/login.php?";
        //http://donixdev.esy.es/chess/login.php?

        const string host = "http://localhost/login.php?";
        WebClient wc;
        MainForm mainform;

        public NameInput(MainForm a)
        {
            InitializeComponent();
            mainform = a;
            wc = new WebClient();
        }

        public bool LoginAndRegister(string username, string password, int type)
        {
            string str = CalculateMD5Hash(password);
            string requestString = host + "type=" + type.ToString() + "&un=" + username + "&pa= " + str;
            string requestWeb = "0";

            try { requestWeb = wc.DownloadString(requestString); } catch (Exception) { }

            return requestWeb == "1";
        }

        private string CalculateMD5Hash(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString("X2"));

            return sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "" && NameTextBox.Text.Length < 18 )
            {
                MessageBox.Show(CalculateMD5Hash(PassTextBox.Text));
                mainform.EnterPlayerName(NameTextBox.Text);
                File.WriteAllText(@"ChessFigures\a.name", NameTextBox.Text);
                this.Close();
            }
        }

        private void NameInput_Load(object sender, EventArgs e)
        {
            string a = "";
            if (File.Exists(@"ChessFigures\a.name"))
                a = File.ReadAllText(@"ChessFigures\a.name");
            NameTextBox.Text = a;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            mainform.Close();
            Close();
        }
    }
}
