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
        //http://localhost/chess/login_client.php?
        //http://donixdev.esy.es/chess/login_client.php?

        const string host = "http://donixdev.esy.es/chess/login_client.php?";
        bool IsLogin = true;
        WebClient wc;
        MainForm mainform;

        //
        //Main Funcs
        //

        //Main
        public NameInput(MainForm a)
        {
            InitializeComponent();
            mainform = a;
            wc = new WebClient();
        }

        //Login/Reg Butt
        private void button1_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "" && NameTextBox.Text.Length < 18)
            {
                if (PassTextBox.Text != "")
                {
                    SubmitButton.Enabled = false;
                    StatusLabel.Text = "";
                    if (!IsLogin)
                    {
                        if (LoginAndRegister(NameTextBox.Text, PassTextBox.Text, 1))
                        {
                            StatusLabel.Text = "Sikeres regisztráció! Jelentkezz be.";
                            PassTextBox.Text = "";
                            SwichButton.PerformClick();
                        }
                        else
                            StatusLabel.Text = "Sikertelen regisztráció! Próbáld újra!";
                    }
                    else
                    {
                        if (LoginAndRegister(NameTextBox.Text, PassTextBox.Text, 0))
                        {
                            mainform.EnterPlayerName(NameTextBox.Text);
                            File.WriteAllText(@"ChessFigures\a.name", NameTextBox.Text);
                            this.Close();
                        }
                        else
                            StatusLabel.Text = "Hibás felhasználói adatok!";

                    }
                }
                else
                    StatusLabel.Text = "Nem írtál be jelszót!";
            }
            else
                StatusLabel.Text = "Nem irtál be felhasználónevet vagy túl hosszú!";

            SubmitButton.Enabled = true;
        }

        //Load
        private void NameInput_Load(object sender, EventArgs e)
        {
            string a = "";
            if (File.Exists(@"ChessFigures\a.name"))
                a = File.ReadAllText(@"ChessFigures\a.name");
            NameTextBox.Text = a;
        }

        //Switch
        private void SwichButton_Click(object sender, EventArgs e)
        {
            if (IsLogin)
            {
                SubmitButton.Text = "Register";
                SwichButton.Text = "Login =>";

                IsLogin = false;
            }
            else
            {
                SubmitButton.Text = "Login";
                SwichButton.Text = "Register =>";

                IsLogin = true;
            }

        }


        //
        //Sub Funcs
        //

        //Exit
        private void ExitButton_Click(object sender, EventArgs e)
        {
            mainform.Close();
            Close();
        }

        //Login & Register
        public bool LoginAndRegister(string username, string password, int type)
        {
            string str = CalculateMD5Hash(password);
            string requestString = host + "type=" + type.ToString() + "&un=" + username + "&pa= " + str;
            string requestWeb = "0";

            try { requestWeb = wc.DownloadString(requestString);
                MessageBox.Show(requestWeb);
            } catch (Exception) { }

            return requestWeb == "1";
        }

        //MD5
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

    }
}
