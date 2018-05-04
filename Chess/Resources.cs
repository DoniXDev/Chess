using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chess
{
    public delegate void FileCheckError(string error);
    public delegate void FileCheckDownloading(string filename);
    public delegate void FileCheckDone();

    class Resources
    {
        public struct Piece
        {
            public int type;
            public int variant;
            public string w_src;
            public string b_src;
        }

        const string localpath = MainForm.subfiles;
        const string fileserver = MainForm.server + @"/chess/units/";

        List<Piece> t;
        WebClient wc;
        FileCheckDone fcd;
        FileCheckError fce;
        FileCheckDownloading Down;
        Thread dt;

        //Create
        public Resources(FileCheckDone a, FileCheckError b, FileCheckDownloading c)
        {
            fcd = a;
            fce = b;
            Down = c;
            t = new List<Piece>();
            wc = new WebClient();
            if (!Directory.Exists(localpath))
             Directory.CreateDirectory(localpath);
            if (!File.Exists(localpath + "b.down"))
                File.WriteAllText(localpath + "b.down", "??????");
        }

        //THREAD CREATOR
        public bool AUpdate(string name)
        {
            string str = "";
            try{ str = wc.DownloadString(Client.shost + "type=0&name=" + name).Split(':')[4]; } catch (Exception ex){ fce.Invoke(ex.Message); }
            if(str == "")
                return false;

            dt = new Thread(()=> Update(str));
            dt.Start();
            return true;
        }

        public void AStop()
        {
            if (dt.IsAlive)
                dt.Abort();
        }

        // WORK //

        //MAIN
        void Update(string piecescode)
        {
            //GET
            //Get shop items/links
            GetListofPieces();

            //Update
            //Refresh start.txt
            DownloadFile("start.txt", "start.txt");

            //Getlocal pieces
            string localcodes = File.ReadAllText(localpath + "b.down");

            //If is the same
            if (localcodes == piecescode)
            {
                fcd.Invoke();
                return;
            }

            //FROM TABLE LOGIC
            string[] name = { "G", "B", "F", "H", "N", "K" };
            string[] team = { "White", "Black" };
            //

            //Start downloadings
            for (int i = 0; i < 6; i++)
                if (piecescode[i] != localcodes[i])
                {
                    DownloadFile(t.Find((v) => v.type == i && v.variant == int.Parse(piecescode[0].ToString())).w_src + ".png", team[0] + name[i] + ".png");
                    DownloadFile(t.Find((v) => v.type == i && v.variant == int.Parse(piecescode[0].ToString())).b_src + ".png", team[1] + name[i] + ".png");
                }
            File.WriteAllText(localpath + "b.down", piecescode);

            fcd.Invoke();
         }

        //Get Datas from server
        void GetListofPieces()
        {
            string a = "";
            try {a = wc.DownloadString(Client.shost + "name=null&type=4"); }catch (Exception){}
            if (a == "")
                fce.Invoke(a);

            string[] b = a.Split('/');
            foreach (string i in b)
                if (i != "")
                {
                    string[] s = i.Split(':');
                    Piece c;
                    c.type = int.Parse(s[0]);
                    c.variant = int.Parse(s[1]);
                    c.w_src = s[4];
                    c.b_src = s[5];
                    t.Add(c);
                }
        }

        //Downloading file
        void DownloadFile(string serverurl, string name)
        {
            Down.Invoke(serverurl);
            try { wc.DownloadFile(fileserver + serverurl, localpath + name); } catch (Exception a) { fce.Invoke(a.Message); }
        }

        /////

    }
}
