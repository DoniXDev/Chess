using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Audio
    {
        string Spath = MainForm.subfiles + "startgame.wav";
        string Mpath = MainForm.subfiles + "move.wav";
        SoundPlayer player = new SoundPlayer();

        public void StartGame()
        {
            if (!File.Exists(Spath))
                return;


            player.SoundLocation = Spath;
            player.Play();
        }

        public void Move()
        {
            if (!File.Exists(Mpath))
                return;

            player.SoundLocation = Mpath;
            player.Play();
        }
    }
}

