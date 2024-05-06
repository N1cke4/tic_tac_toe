using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp11
{
    internal class Player
    {
        public Player(string name)
        {
        this.name = name;
            for (int i = 0; i < combo.Length; i++)
                combo[i] = false;

        }
        private string name;
        private bool iswin()
        {
            if (combo[0]&&
                combo[1]&&
                combo[2])
            return true;

            if (combo[3] &&
                combo[4] &&
                combo[5])
                return true;

            if (combo[6] &&
                combo[7] &&
                combo[8])
                return true;

            if (combo[0] &&
                combo[3] &&
                combo[6])
                return true;

            if (combo[1] &&
                combo[4] &&
                combo[7])
                return true;

            if (combo[2] &&
                combo[5] &&
                combo[8])
                return true;

            if (combo[0] &&
                combo[4] &&
                combo[8])
                return true;

            if (combo[2] &&
                combo[4] &&
                combo[6])
                return true;

            return false;
        }
        
        private bool[] combo = [false,false,false,false,false,false,false,false,false];
        public string setcombo(int n)
        {
            combo[n] = true;
            if (iswin())
                return "Win " + name;
            return "Win";

            
        }
    }
}
