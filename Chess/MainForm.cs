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
using Chess;
using System.Threading;
using System.Net;

namespace Chess
{
    public delegate void UnitDestroly(Unit a);
    public delegate void SakkFor(Player a);

    //TODO

    // 1.2

    //ONCE
    // Erőforrásoakt letültő rendszer letöltő rendszer

    //


    public partial class MainForm : Form
    {
        //Developement tools
            // ||  http://localhost/chess  ||  http://donixdev.esy.es || //

        public const string version = "1.2";
        public const bool IsDev = false;
        public const string server = "http://donixdev.esy.es";
        //

        public MainForm()
        {
            InitializeComponent();
        }

        public Graphics graphics;
        public Table table;
        public NameInput nameinput;
        public UnitDestroly unitdestroly;
        public SakkFor sakkfor;
        public ResetGame resetgame;
        public GEndForm endform;
        Client kliens;

        public FindMatch findmatch;
        public GetPlayerMove getplayermove;

        Graphics POUPG;
        Graphics PTUPG;

        int[] PlayerOneUnits;
        int[] PlayerTwoUnits;


        public string PlayerName = "";
        public Player PlayerOne;

        //LOAD
        private void NewForm_Load(object sender, EventArgs e)
        {
            graphics = Screen.CreateGraphics();
            unitdestroly = OnUnitDestroly;
            sakkfor = OnSakkFor;
            findmatch = MatchFound;
            getplayermove = OppMove;
            resetgame = Reset;
            endform = new GEndForm(this);

            label5.Text += version;
            string a = "";

            if (a != "")
                EnterPlayerName(a);
            else
            {
                this.Opacity = 0;
                nameinput = new Chess.NameInput(this);
                nameinput.Show();
            }



        }
        public void EnterPlayerName(string a)
        {
            PlayerOne = new Player(a);
            this.Opacity = 100;

            kliens = new Client(PlayerOne, getplayermove, findmatch, richTextBox1, resetgame, this);
        }

        //EXIT BUTTON
        private void ExitButton_Click(object sender, EventArgs e)
        {
            kliens.Dodge();
            kliens.LeaveQueue();
            endform.Close();
            Close();
        }

        //START BUTTON
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (kliens.JoinQueue())
                StartButton.Visible = false;
        }

        int x;
        int y;
        bool selected = false;

        // On sreen click
        private void Screen_MouseClick(object sender, MouseEventArgs e)
        {
            //if endgame
            if (table != null)
                if (table.turn == -1)
                    return;

            if (!selected)
            {
                x = e.X / 26;
                y = e.Y / 26;

                if (table != null)
                    if(table.ShowPredictions(x, y))
                        selected = true;

            }
            else
            {
                if (e.Button == MouseButtons.Left)
                    if (table.turn % 2 == table.players.FindIndex((a) => PlayerOne == a))
                        kliens.Move(x, y, new Chess.Move((e.X / 26) - x, (e.Y / 26) - y), table.turn);
                        //table.Move(x, y, new Chess.Move((e.X / 26) - x, (e.Y / 26) - y), table.players.Find((a) => PlayerOne == a));

                table.Show();

                selected = false;
            }
        }

        //MAIN

        //Reset!
        public void Reset()
        {
            //Game win/lose || dodge not
            if (table.endgame != 2)
                if (table.players.Find((v) => v != table.players[table.endgame]) == PlayerOne)
                {
                    int val = kliens.GameEnd(PlayerOne, table.players[table.endgame]);
                    endform.Win(val);
                }
                else
                    endform.Lose();
            

            //Reset: Game
            table = null;
            kliens = new Client(PlayerOne, getplayermove, findmatch, richTextBox1, resetgame, this);
            richTextBox1.Invoke((MethodInvoker)(() => richTextBox1.Text += "--------------------------"));
            StartButton.Invoke((MethodInvoker)(() => StartButton.Visible = true));
            //Reset: Sakk label
            PlayerOneSakkL.Invoke((MethodInvoker)(() => PlayerOneSakkL.Visible = false));
            PlayerTwoSakkL.Invoke((MethodInvoker)(() => PlayerTwoSakkL.Visible = false));
            //Reset: Name label
            PlayerOneNameL.Invoke((MethodInvoker)(() => PlayerOneNameL.Visible = false));
            PlayerTwoNameL.Invoke((MethodInvoker)(() => PlayerTwoNameL.Visible = false));
            //SetuUp: ELO label
            PlayerOneELOLabel.Invoke((MethodInvoker)(() => PlayerOneELOLabel.Visible = false));
            PlayerTwoELOLabel.Invoke((MethodInvoker)(() => PlayerTwoELOLabel.Visible = false));
            PlayerOneELORankLabel.Invoke((MethodInvoker)(() => PlayerOneELORankLabel.Visible = false));
            PlayerTwoELORankLabel.Invoke((MethodInvoker)(() => PlayerTwoELORankLabel.Visible = false));

            Graphics[] c = { PTUPG, POUPG };
            graphics.FillRectangle(Brushes.WhiteSmoke, 0, 0, 216, 216);

            foreach (Graphics u in c)
                u.FillRectangle(Brushes.WhiteSmoke, 0, 0, 131, 27);
            c = null;

        }
           
        //Write out player names
        void SetUpPlayerNamesAndTable()
        {
            //SetUp: Name label
            PlayerOneNameL.Invoke((MethodInvoker)(() => PlayerOneNameL.Visible = true));
            PlayerTwoNameL.Invoke((MethodInvoker)(() => PlayerTwoNameL.Visible = true));
            //SetuUp: ELO label
            PlayerOneELOLabel.Invoke((MethodInvoker)(() => PlayerOneELOLabel.Visible = true));
            PlayerTwoELOLabel.Invoke((MethodInvoker)(() => PlayerTwoELOLabel.Visible = true));
            PlayerOneELORankLabel.Invoke((MethodInvoker)(() => PlayerOneELORankLabel.Visible = true));
            PlayerTwoELORankLabel.Invoke((MethodInvoker)(() => PlayerTwoELORankLabel.Visible = true));
            //SetUp: Name 
            PlayerOneNameL.Invoke((MethodInvoker)(() => PlayerOneNameL.Text = "[ " + table.players[0].Name + " ]"));
            PlayerTwoNameL.Invoke((MethodInvoker)(() => PlayerTwoNameL.Text = "[ " + table.players[1].Name + " ]"));
            //SetuUp: ELO
            Thread a = new Thread(SetUpPlayerDatas);
            a.Start();
            //SetUp: Table
            POUPG = PlayerOneUnitsP.CreateGraphics();
            PTUPG = PlayerTwoUnitsP.CreateGraphics();
            Graphics[] c = {PTUPG, POUPG};

            foreach (Graphics u in c)
                u.DrawRectangle(Pens.Black, 0, 0, 130, 26);
        }

        //DownlaodPlayerDatas
        void SetUpPlayerDatas()
        {
            //Get mmr data
            WebClient a = new WebClient();
            string[] str = new string[2];
            for (int i = 0; i < 2; i++)
                try {str[i] = a.DownloadString(Client.shost + "type=0&name=" + table.players[i].Name); } catch (Exception) { return; }
           
            //Setlabels
            PlayerOneELOLabel.Invoke((MethodInvoker)(() => PlayerOneELOLabel.Text = str[0].Split(':')[2]));
            PlayerTwoELOLabel.Invoke((MethodInvoker)(() => PlayerTwoELOLabel.Text = str[1].Split(':')[2]));

            //Get rank data
            string ranks = "";
            try { ranks = a.DownloadString(Client.shost + "type=3&name=" + table.players[0].Name); } catch (Exception) { return; }
            if (ranks == "")
                return;

            //Setlabels
            List<string> split = new List<string>(ranks.Split('/'));
            int[] s = new int[2];
            for (int i = 0; i < 2; i++)
                s[i] = split.FindIndex((v) => v.Split(':')[0] == table.players[i].Name)+1;
            PlayerOneELORankLabel.Invoke((MethodInvoker)(() => PlayerOneELORankLabel.Text = (s[0]!=0)? "|#" + s[0].ToString() + "|" : "" ));
            PlayerTwoELORankLabel.Invoke((MethodInvoker)(() => PlayerTwoELORankLabel.Text = (s[1]!=0)? "|#" + s[1].ToString() + "|" : ""));
            return;
        }

        //Write out Units Destrolyed
        Font WriteOutFont = new Font(FontFamily.GenericMonospace, 10);
        public void OnUnitDestroly(Unit a)
        {
            if (a != null)
                if (PlayerOne == a.player)
                    PlayerOneUnits[table.GetIDByUnit(a)-1]++;
                else
                    PlayerTwoUnits[table.GetIDByUnit(a)-1]++;


            for (int i = 0; i < PlayerOneUnits.Length; i++)
            {
                POUPG.DrawImage(table.figures[i], (i * 26) + 1, 1);
                POUPG.DrawString(PlayerOneUnits[i].ToString(), WriteOutFont, Brushes.Black, (i * 26) + 1 + 7, 1 + 11);
            }

            for (int i = 0; i < PlayerTwoUnits.Length; i++)
            {
                PTUPG.DrawImage(table.figures[i+6], (i * 26) + 1, 1);
                PTUPG.DrawString(PlayerTwoUnits[i].ToString(), WriteOutFont, Brushes.White, (i * 26) + 1 + 7, 1 + 11);
            }

        }

        //Sakkfor
        public void OnSakkFor(Player a)
        {
            if (a == null)
            {
                PlayerOneSakkL.Invoke((MethodInvoker)(() => PlayerOneSakkL.Visible = false));
                PlayerTwoSakkL.Invoke((MethodInvoker)(() => PlayerTwoSakkL.Visible = false));
            }

            if (a == table.players[0])
                PlayerOneSakkL.Invoke((MethodInvoker)(() => PlayerOneSakkL.Visible = true));
            if (a == table.players[1])
                PlayerTwoSakkL.Invoke((MethodInvoker)(() => PlayerTwoSakkL.Visible = true));
        }

        //Clinet Queue func
        public void MatchFound(Player a, int b)
        {
            if (table != null)
                return;

            //Create Game
            if(b == 1)
                table = new Table(graphics, PlayerOne, a, richTextBox1, unitdestroly, sakkfor, resetgame);
            if (b == 2)
                table = new Table(graphics, a, PlayerOne, richTextBox1, unitdestroly, sakkfor, resetgame);

            richTextBox1.Invoke((MethodInvoker)(() => richTextBox1.Text += "|C| Match found : | " + PlayerOne.Name + " | vs | " + a.Name +  " |"));



            //SetupGame
            SetUpPlayerNamesAndTable();

            //Units Destrolyed  income
            PlayerOneUnits = new int[5];
            PlayerTwoUnits = new int[5];
            OnUnitDestroly(null);
        }

        


        public void OppMove(int x, int y, Move a, int b)
        {
            if (table != null)
            {
                if (table.turn != b)
                    return;

                int str = table.turn % 2;
                int str2 = table.turn;

                try { table.Move(x, y, a, table.players[str]); }
                catch (Exception) { if (table != null) table.turn = str2; }
            }
        }














        // 0
        private void Screen_MouseMove(object sender, MouseEventArgs e)
        {

        }

        // 0
        private void Screen_Paint(object sender, PaintEventArgs e)
        {

        }

        // Output auto sroll
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            List<string> a = new List<string>(richTextBox1.Lines);

            if (a.Count > 22)
                for (int i = 0; i < a.Count - 25; i++)
                    a[0] = "";

            richTextBox1.Text = "";
            a.ForEach((u) =>
            {
                if (u != "")
                    richTextBox1.Text += u + Environment.NewLine;
            }); 
        }

        //Move Form

        bool dragging;
        Point offset;

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X,currentScreenPos.Y - offset.Y);

                if (endform.Enabled == true)
                    endform.SetPosition();
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PlayerOneNameL_Click(object sender, EventArgs e)
        {

        }
    }
}
