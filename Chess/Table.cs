using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Chess
{
    //By:
    // Donix -- 2018. 03. 02
    //


    //Lépés
    public class Move
    {
        public int ChangeX;
        public int ChangeY;
        public bool special;

        public Move(int x, int y)
        {
            ChangeX = x;
            ChangeY = y;
        }
        public Move(int x, int y, bool spec)
        {
            ChangeX = x;
            ChangeY = y;
            special = spec;
        }
    }

    public struct LastMove
    {
        public int x;
        public int y;
        public Move end;
    }

    //Unit => Gyalog, Futo, Huszar, Bastya, Kiraly, KirályN
    //G-B-F-H-N-K (ID)
    //+ lépések

    public class Unit
    {
        public int x;
        public int y;
        public bool EHJB = true;
        public Player player = null;
        public int id;

        public Unit(int a, int b, Player c)
        {
            x = a;
            y = b;
            player = c;
        } //CONS1
        public Unit(int a, int b)
        {
            x = a;
            y = b;
        } //CONS2
    }

    public class Gyalog : Unit
    {
        public Gyalog(int a, int b, Player c) : base(a, b, c) { id = 1; }
        public bool EHJB = false;
        public int id = 1;
    }

    public class Bastya : Unit
    {
        public Bastya(int a, int b, Player c) : base(a, b, c) { id = 2; }
        public bool EHJB = true;
        public int id;

    }

    public class Futo : Unit
    {
        public Futo(int a, int b, Player c) : base(a, b, c) { id = 3; }
        public bool EHJB = true;
        public int id;
    }

    public class Huszar : Unit
    {
        public Huszar(int a, int b, Player c) : base(a, b, c) { id = 4; }
        public bool EHJB = true;
        public int id;
    }

    public class KiralyN : Unit
    {
        public KiralyN(int a, int b, Player c) : base(a, b, c) { id = 5; }
        public bool EHJB = true;
        public int id;
    }

    public class Kiraly : Unit
    {
        public Kiraly(int a, int b, Player c) : base(a, b, c) { id = 6; }
        public bool EHJB = true;
        public int id ;
    }

    public class Table
    {
        const string FileDir = @"ChessFigures\"; //FileDIR

        //FFY

        Graphics graphics;
        public int turn = 0;
        public int endgame = 2;
        public int[] sakkfor = {0,0};
        List<Unit> units = new List<Unit>();
        public List<Player> players = new List<Player>();
        public List<Image> figures = new List<Image>(); //[White]G-B-F-H-N-K/[Black]G-B-F-H-N-K
        public LastMove lastmove;

        UnitDestroly unitdestroly;
        SakkFor sakkfordel;

        RichTextBox output;


        //Local Functions

        public List<Move> WithReversedMoves(List<Move> a, bool FLJB)
        {
            List<Move> t = new List<Move>();
            foreach (Move i in a)
            {
                int x = i.ChangeX;
                int y = i.ChangeY;
                bool spec = i.special; 

                //1
                t.Add(new Move(x,y,spec));
                if (!FLJB)
                {
                    //2
                    Move str = new Move(x, y, spec);
                    str.ChangeY *=  -1;
                    if(!IsAviableMoves(t,str))
                        t.Add(str);
                }
                else
                {
                    //2
                    if (y != 0)
                    {
                        Move str = new Move(x, y, spec);
                        str.ChangeY *= -1;
                        if (!IsAviableMoves(t, str))
                            t.Add(str);
                    }

                    //3
                    if (x != 0)
                    {
                        Move str2 = new Move(x, y, spec);
                        str2.ChangeX *= -1;
                        if (!IsAviableMoves(t, str2))
                            t.Add(str2);
                    }

                    //4
                    Move str3 = new Move(x, y, spec);
                    if (x != 0)
                        str3.ChangeY *= -1;
                    if (y != 0)
                        str3.ChangeX *= -1;
                    if (y != 0 && x != 0)
                        if (!IsAviableMoves(t, str3))
                            t.Add(str3);
                }

            }
            return t;
        }

        bool IsUnitBlockedBy(Move a, Unit b)
        {
            int x = a.ChangeX;
            int y = a.ChangeY;
            int TargetX = a.ChangeX + b.x;
            int TargetY = a.ChangeY + b.y;

            int max = (Math.Abs(x) > Math.Abs(y)) ? x : y;
            if (max < 0) max = max * -1;


            int ModX = 0;
            if (x > 0)ModX = -1;
            if (x < 0)ModX = 1;

            int ModY = 0;
            if (y > 0)ModY = -1;
            if (y < 0)ModY = 1;

            int first = 0;
            for (int step = 0; step < max; step++)
            {            
                Unit GET = SelectUnitByXY(TargetX + (step * ModX), TargetY + (step * ModY));
                if (GetIDByUnit(GET) > 0)
                    if (GET.player == b.player)
                        return false;
                    else
                        first++;              
            }

            if (first <2 )
                if(first == 1 && GetIDByUnit(SelectUnitByXY(TargetX, TargetY)) == 0)
                    return false;
                else
                    return true;
            else
                return false;      
        }

        bool IsVaildMove(Move a, Unit b)
        { 
            int X = a.ChangeX + b.x;
            int Y = a.ChangeY + b.y;

            //Base statement
            if (X > 7 || X < 0)
                return false;
            if (Y > 7 || Y < 0)
                return false;
            if (SelectUnitByXY(X, Y).player == b.player)
                return false;

            //Special Statement

            //Gyalog
            if (typeof(Gyalog).Equals(b.GetType()))
            {
                if (players[1] == b.player)
                {
                    if (!(a.ChangeY < 0))
                        return false;
                }
                else
                    if (!(a.ChangeY > 0))
                    return false;

                if (a.ChangeX != 0)
                    if (SelectUnitByXY(X, Y).GetType() == typeof(Unit))
                        return false;

                if (!(b.y == 1 || b.y == 6) && a.special)
                    return false;

                if (SelectUnitByXY(X, Y).GetType() != typeof(Unit)) 
                    if (a.ChangeX == 0)
                        return false;

            }

            if(!(typeof(Huszar).Equals(b.GetType())))
                if (!IsUnitBlockedBy(a, b))
                    return false;

            return true;
        }

        bool IsAviableMoves(List<Move> a,Move b)
        {
            foreach (Move i in a)
                if (i.ChangeX == b.ChangeX && i.ChangeY == b.ChangeY)
                    return true;
            return false;
        }

        int IndexOFUnit(Unit a)
        {
            for (int i = 0; i < units.Count; i++)
                if (a == units[i])
                    return i;
            return -1;
        }

        Unit SelectUnitByXY(int x, int y)
        {
            foreach (Unit item in units)
                if (item.x == x && item.y == y)
                    return item;
            return null;
        }

        List<Image> GetFiguresIMG()
        {
            List<Image> a = new List<Image>();
            string[] name = { "G", "B", "F", "H", "N", "K" };
            string[] team = { "White", "Black" };

            foreach (string itemOne in team)
                foreach (string itemTwo in name)
                {
                    Bitmap c = new Bitmap(Image.FromFile(FileDir + itemOne + itemTwo + ".png"));
                    c.MakeTransparent(Color.White);
                    a.Add((Image)c);
                }
            return a;
        }

        Player SelectPlayer(int a)
        {
            if (a > 0)
                return players[0];
            if (a < 0)
                return players[1];
            return new Player("null");
        }

        Image GetImageByUnit(Unit a)
        {
            int b = (a.player == players[0]) ? 0 : 6;
            return figures[GetIDByUnit(a) + b-1];

        }

        public int GetIDByUnit(Unit b)
        {
            if (b != null)
            {
                Type a = b.GetType();
                if (a == typeof(Unit))
                    return 0;
                if (a == typeof(Gyalog))
                    return 1;
                if (a == typeof(Bastya))
                    return 2;
                if (a == typeof(Futo))
                    return 3;
                if (a == typeof(Huszar))
                    return 4;
                if (a == typeof(KiralyN))
                    return 5;
                if (a == typeof(Kiraly))
                    return 6;
            }
            return 0;

        }

        Unit GetUnitByID(int id,int x, int y)
        {
            Unit a = null;
            switch (Math.Abs(id))
            {
                case 0:
                    a = new Unit(x, y, SelectPlayer(id));
                    break;
                case 1 :
                    a = new Gyalog(x, y,SelectPlayer(id));
                    break;
                case 2:
                    a = new Bastya(x, y, SelectPlayer(id));
                    break;
                case 3:
                    a = new Futo(x, y, SelectPlayer(id));
                    break;
                case 4:
                    a = new Huszar(x, y, SelectPlayer(id));
                    break;
                case 5:
                    a = new KiralyN(x, y, SelectPlayer(id));
                    break;
                case 6:
                    a = new Kiraly(x, y, SelectPlayer(id));
                    break;
            }
            return a;
        }

        List<Move> GetMoves(Unit u)
        {
            int id = GetIDByUnit(u);
            List<Move> a = new List<Move>();

            switch (id)
            {
                case 0:
                    break;
                case 1:
                    a.Add(new Move(0, 1));
                    a.Add(new Move(0, 2, true));
                    a.Add(new Move(1, 1));
                    a.Add(new Move(-1, 1));
                    break;             
                case 2:
                    for (int i = 1; i < 8; i++)
                        a.Add(new Move(1 * i, 0));
                    for (int i = 1; i < 8; i++)
                        a.Add(new Move(0, 1 * i));
                    break;
                case 3:
                    for (int i = 1; i < 8; i++)
                        a.Add(new Move(1 * i, i * 1));
                    break;
                case 4:
                    a.Add(new Move(1, 2));
                    a.Add(new Move(2, 1));
                    break;
                case 5:
                    for (int i = 1; i < 8; i++)
                        a.Add(new Move(1 * i, 0));
                    for (int i = 1; i < 8; i++)
                        a.Add(new Move(0, 1 * i));
                    for (int i = 1; i < 8; i++)
                        a.Add(new Move(1 * i, i * 1));
                    break;
                case 6:
                    a.Add(new Move(1, 0));
                    a.Add(new Move(0, 1));
                    a.Add(new Move(1, 1));
                    break;
            }

            return a;
        }

        List<Unit> SetUpTable()
        {
            List<Unit> a = new List<Unit>();
            string[] raw = File.ReadAllLines(FileDir + "start.txt");

            for (int y = 0; y < 8; y++)
            {
                string[] splitted = raw[y].Split('.');
                for (int x = 0; x < 8; x++)
                    a.Add(GetUnitByID(int.Parse(splitted[x]), x, y));
            }
            return a;
        }

        bool IsSakk(Player a)
        {
            Unit Kiraly = units.Find((item) => item.GetType() == typeof(Kiraly) && item.player == a);
            bool returnvalue = false;

            List<Move> b = new List<Move>();
            units.ForEach((v) => WithReversedMoves(GetMoves(v), v.EHJB).ForEach((u) =>
            {
                int x = u.ChangeX + v.x;
                int y = u.ChangeY + v.y;
                if(IsVaildMove(u, v))
                    if(x == Kiraly.x && y == Kiraly.y)
                        returnvalue = true;
            }));
            return returnvalue;
        }


        //Public
        public void Show()
        {
            //Border
            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                    graphics.DrawRectangle(Pens.Black, new Rectangle((x * 26), (y * 26), 26, 26));


            //Clearup
            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                        graphics.FillRectangle((x%2 == ((y%2 == 0) ? 1: 0)) ? Brushes.Gray : Brushes.White, new Rectangle((x * 26) + 1, (y * 26) + 1, 25, 25));
            
            //Set
            foreach (Unit u in units)
           {
                     if(GetIDByUnit(u) != 0)
                          graphics.DrawImage(GetImageByUnit(u), (u.x * 26) + 1, (u.y * 26) + 1);
            }

            //LastMove
            if(lastmove.end != null)
                LastMoveIndicator(lastmove.x, lastmove.y, lastmove.end);

        }

        public void LastMoveIndicator(int x, int y, Move a)
        {
            graphics.DrawLine(new Pen(Color.Purple, 3), ((x+1) * 26) - 13, ((y+1) * 26) - 13, (((x+1) + a.ChangeX) * 26) - 13, (((y+1) + a.ChangeY) * 26) - 13);
        }

        public bool ShowPredictions(int x, int y)
        {
            Unit selected = SelectUnitByXY(x, y);
            List<Move> ez = WithReversedMoves(GetMoves(selected), selected.EHJB);
            var aviable = ez.FindAll((item) => IsVaildMove(item, selected));
            if (aviable.Count == 0)
                return false;
            aviable.ForEach((item) => graphics.DrawRectangle(new Pen(Color.Red,2), new Rectangle(((selected.x + item.ChangeX) * 26), ((selected.y + item.ChangeY )* 26), 26, 26)));
            return true;
        }

        public Table(Graphics a, Player b, Player c, RichTextBox d, UnitDestroly e, SakkFor f)
        {
            //Get Grap Create Recs
            output = d;

            graphics = a;

            unitdestroly = e;
            sakkfordel = f;
            //Add Players
            players.Add(b); players.Add(c);

            //Readin Files
            figures = GetFiguresIMG();

            //Setup Table 
            units = SetUpTable();
            Show();
        }

        public bool Move(int x, int y, Move b, Player c)
        {
            Unit selected = SelectUnitByXY(x, y);

            List<Move> aviable = WithReversedMoves(GetMoves(selected), selected.EHJB);

            if (IsAviableMoves(aviable, b) && IsVaildMove(b, selected) && c == selected.player && turn > -1)
            {
                Unit FI = selected;
                Unit SI = SelectUnitByXY(selected.x + b.ChangeX, selected.y + b.ChangeY);

                if (SI.GetType() == typeof(Kiraly))
                    return false;

                lastmove.x = FI.x;
                lastmove.y = FI.y;
                lastmove.end = b;

                int srt1 = FI.x;
                int srt2 = FI.y;
                Player str3 = FI.player;

                FI.x = SI.x;
                FI.y = SI.y;


                if (FI.GetType() == typeof(Gyalog) && (FI.y == 0 || FI.y == 7))
                {
                    units.Add(new KiralyN(FI.x, FI.y, str3));
                    units.Remove(FI);
                }

                if (SI.GetType() != typeof(Unit))
                    unitdestroly.Invoke(SI);

                units.Remove(SI);
                units.Add(new Unit(srt1, srt2));

                output.Invoke((MethodInvoker)(() => output.Text += "T:"+ turn + " [" + c.Name + "] (" + x + ":" + y + ") => (" + (x+b.ChangeX).ToString() + ":" + (y+b.ChangeY).ToString() + ") with: " + selected.GetType().ToString().Split('.')[1]   +  Environment.NewLine));

                //Sakk / Matt
                bool kk = false;
                Player given = null;
                players.ForEach((v) => {
                    int index = players.FindIndex((u) => u == v);
                    if (IsSakk(v))
                    {
                        sakkfor[index]++;
                        if (!(sakkfor[index] > 1))
                        {
                            output.Invoke((MethodInvoker)(() => output.Text += "SAKK for " + v.Name + Environment.NewLine));
                            given = v;
                        }
                        else
                        {
                            endgame = index;
                            turn = -1;
                            output.Invoke((MethodInvoker)(() => output.Text += "SAKKMATT for " + v.Name + Environment.NewLine));
                            output.Invoke((MethodInvoker)(() => output.Text += "Win for " + players.Find((u) => u != v).Name  + Environment.NewLine));
                            kk = true;
                        }
                    }
                    else
                        sakkfor[index] = 0;
                });

                sakkfordel.Invoke(given);
                Show();

                if (kk)
                    return true;

                if (!(turn<0))
                    turn++;   
                return true;
            }
            return false;
        }
    }
}