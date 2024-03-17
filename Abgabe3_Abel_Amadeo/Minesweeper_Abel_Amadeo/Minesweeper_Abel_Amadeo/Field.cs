using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_Abel_Amadeo
{
    internal class Field
    {
        private bool isMine;
        private bool isFlagged;
        private bool isRevealed;

        public Field()
        {
            isMine = false;
            isFlagged = false;
            isRevealed = false;
        }

        public bool IsMine()
        {
            return isMine;
        }

        public bool IsFlagged()
        {
            return isFlagged;
        }

        public void ToggleFlag()
        {
            isFlagged = !isFlagged;
        }

        public bool IsRevealed()
        {
            return isRevealed;
        }

        public void Reveal()
        {
            if (isRevealed)
            {
                return;
            }
            
            isRevealed = true;

            if (isMine)
            {
                Console.WriteLine("GAME OVER");
            }
        }

        public void SetMine()
        {
            isMine = true;
        }
    }
}
