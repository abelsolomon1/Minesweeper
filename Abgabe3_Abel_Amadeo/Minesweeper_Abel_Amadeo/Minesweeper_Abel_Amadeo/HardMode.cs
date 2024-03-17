using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_Abel_Amadeo
{
    internal class HardMode : IDifficulty
    {
        //Properties vom Interface
        public int Width { get; set; }
        public int Height { get; set; }
        public int Mines { get; set; }

        //Konstruktor
        public HardMode(int width, int height, int mines)
        {
            Width = width;
            Height = height;
            Mines = mines;
        }


        public int GetWidth()
        {
            return Width;
        }

        public int GetHeight()
        {
            return Height;
        }
        public int GetMines()
        {
            return Mines;
        }
    }
}
