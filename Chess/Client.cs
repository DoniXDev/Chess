﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace Chess
{
    public delegate void GetPlayerMove(int x,int y, Move a, int b);
    public delegate void FindMatch(Player a, int start);
    public delegate void ResetGame();

    class Client
    {
        //Developement tools / Server swich
        //http://localhost/chess
        //http://donixdev.esy.es

        const string server = "http://donixdev.esy.es";
        //

        public const string host = server + "/chess/game_manager.php?";
        public const string shost = server +  "/chess/statics_api.php?";
        public Player player;
        public WebClient wc;

        int lobby;
        bool logged = false;

        GetPlayerMove getplayermove;
        FindMatch findmatch;
        RichTextBox output;
        ResetGame resetgame;

        Thread MatchFinder;
        Thread MoveFinder;

        MainForm mainform;

        //Open
        public Client(Player a, GetPlayerMove b, FindMatch c, RichTextBox d, ResetGame e, MainForm f)
        {
            player = a;
            wc = new WebClient();

            mainform = f;
            getplayermove = b;
            findmatch = c;
            output = d;
            resetgame = e;

            MatchFinder = new Thread(FindQueue);
            MoveFinder = new Thread(GetOpponentMove);
        }

        //Queue func
        public bool JoinQueue()
        {
            string jointxt = "type=0&name=" + player.Name;
            output.Text += "|C| Connecting to server ...";

            string str = "";

            try{ str = wc.DownloadString(host + jointxt);}
            catch (WebException m){str = m.Message;}

            if (str != "ok")
            {
                output.Text += "|C| Unable to connect to server! (" + str + ")";
                return false;
            }
            else
                output.Text += "|C| Connected!";

            logged = true;
            MatchFinder.Start();

            output.Invoke((MethodInvoker)(() => output.Text += "|C| In queue as | " + player.Name + " | ..."));
            return true;
        }
        void FindQueue() //REF
        {
            WebClient a = new WebClient();
            string jointxt = "type=2&name=" + player.Name;

            while (true)
            {
                string str = "v";
                try { str = a.DownloadString(host + jointxt); } catch (Exception) { };

                if (str != "v")
                {
                    int id = int.Parse(str);
                    lobby = id;

                    MoveFinder.Start();
                    return;
                }
                Thread.Sleep(100); 
            }
        }
        public void LeaveQueue()
        {
            string jointxt = "type=1&name=" + player.Name;

            if(logged)
                try{wc.DownloadString(host + jointxt);}catch (Exception){};

            if (MatchFinder.IsAlive)
                MatchFinder.Abort();

            if (MoveFinder.IsAlive)
                MoveFinder.Abort();
        }


        //Match func
        //Downlaod Move from db
        void GetOpponentMove() //REF
        {
            WebClient a = new WebClient();
            string gettxt = "type=3&name=" + player.Name + "&id=" + lobby;

            while (true)
            {
                string str = "?";
                try { str = a.DownloadString(host + gettxt);} catch (Exception){};

                if (str == "?")
                {
                    output.Text += "!!! Error from server, game canceled. Exit !!!" + Environment.NewLine;
                    return;
                }

                if (str != "")
                {
                    string[] splitted = str.Split(';');

                    string wp = splitted[0];
                    string bp = splitted[1];
                    string move = splitted[2];
                    int turn = int.Parse(splitted[3]);

                    if (move == "START")
                    {
                        findmatch.Invoke(new Player((wp == player.Name) ? bp : wp), (wp == player.Name) ? 1 : 2);
                    }
                    else if (move == "DODGE")
                    {
                        output.Invoke((MethodInvoker)(() => output.Text += "Your opponent left the game!" + Environment.NewLine));
                        resetgame.Invoke();
                        return;
                    }
                    else
                    {
                        string[] movesplitted = move.Split('*');
                        string[] startpos = movesplitted[0].Split(':');
                        string[] movepos = movesplitted[1].Split(':');

                        getplayermove.Invoke(int.Parse(startpos[0]), int.Parse(startpos[1]), new Move(int.Parse(movepos[0]), int.Parse(movepos[1])), turn);
                    }
                }
                Thread.Sleep(1000);
            }
        }

        //Upload Move & Dodge & GameEND to db
        public void Dodge()
        {
            if(mainform.table != null)
                if (mainform.table.endgame != 2)
                    return;

            string jointxt = "type=4&name=" + player.Name + "&turn=" + "-1" + "&move=" + "DODGE" + "&id=" + lobby;
            if (logged)
                try { wc.DownloadString(host + jointxt); } catch (Exception) { };

        }
        public bool Move(int x, int y, Move a, int t)
        {

            string str = x + ":" + y + "*" + a.ChangeX + ":" + a.ChangeY;
                

            string jointxt = "type=4&name=" + player.Name + "&turn=" + t + "&move=" + str + "&id=" + lobby;
            
            if (wc.DownloadString(host + jointxt) == "ok")
                return true;
            else
                return false;
        }
        public int GameEnd(Player p1, Player p2)
        {
            try{return int.Parse(wc.DownloadString(shost + "type=1&name=" + p1.Name + "&los=" + p2.Name));}
            catch (Exception){ return 0;}
        }
        //

    }
}
 