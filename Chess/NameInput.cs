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
        //http://localhost/chess/login_api.php?
        //http://donixdev.esy.es/chess/login_api.php?

        const string host = "http://donixdev.esy.es/chess/login_api.php?";
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
            if (NameTextBox.Text != "" && NameTextBox.Text.Length < 18 && NameTextBox.Text.Length > 3)
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
                        {
                            PassTextBox.Clear();
                            StatusLabel.Text = "Hibás felhasználói adatok!";
                        }
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
            label5.Text += MainForm.version;
            string a = "";
            if (File.Exists(@"ChessFigures\a.name"))
                a = File.ReadAllText(@"ChessFigures\a.name");
            NameTextBox.Text = a;

            //Is up to date
            if (IsNewVersion())
                BlockLogin();

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


        //Update FUNCT
        //Update button
        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://donixdev.esy.es/chess/index.php");
            ExitButton.PerformClick();
        }
        public void BlockLogin()
        {
            SubmitButton.Enabled = false;
            SwichButton.Enabled = false;

            label1.Visible = false;
            label2.Visible = false;
            NameTextBox.Visible = false;
            PassTextBox.Visible = false;

            label4.Visible = true;
        }
        public bool IsNewVersion()
        {
            string str = "";

            try{ str = wc.DownloadString(Client.shost + "type=2"); }
            catch (Exception){ return true; }
            if (str != MainForm.version)
                return true;
            return false;
        }
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

            try { requestWeb = wc.DownloadString(requestString);} catch (Exception) { }

            return requestWeb == "1";
        }

        //MD5
        private string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] pass = Encoding.UTF8.GetBytes(input);
                byte[] hash = md5.ComputeHash(pass);
                return BitConverter.ToString(hash).Replace("-", "");
            }
        }

        private void PassTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                SubmitButton.PerformClick();
        }

        private void PassTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
