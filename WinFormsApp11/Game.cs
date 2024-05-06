using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp11
{
    internal class Game
    {

      


        private string[] symbol = ["X", "O"];
        private int steps = 0;
        private Player[] Player = [new Player("X"), new Player("O")];

        public void Click(Button button, int n, Label label)
        {
            if (button.Text != "") 
                return; 
                int step = steps%symbol.Length;
            label.Text = Player[step].setcombo(n);
            steps++;
                button.Text = symbol[step];



        }

    }
}
