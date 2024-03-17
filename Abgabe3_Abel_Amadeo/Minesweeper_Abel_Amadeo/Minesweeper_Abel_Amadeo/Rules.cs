using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_Abel_Amadeo
{
    internal class Rules
    {
        public void showRules()
        {
            Console.WriteLine("Welcome to Minesweeper! Here's how to play:\n");
            Console.WriteLine("- Type in your coordinates to choose a Field.");
            Console.WriteLine("- Press 'r' to reveal the chosen Field.");
            Console.WriteLine("- Press 'f' to flag a potential mine.");
            Console.WriteLine("- Press 'u' to undo your last move if needed.\n");
            Console.WriteLine("Be careful not to reveal any mines, or it's GAME OVER!");
            Console.WriteLine("Keep track of the remaining mines by counting your flags.");
        }
    }
}
