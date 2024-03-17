using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_Abel_Amadeo
{
    internal class FlagCounter
    {
        private int count;

        public FlagCounter(int totalFlags)
        {
            count = totalFlags;
        }

        public void IncreaseCount()
        {
            count++;
        }

        public void DecreaseCount()
        {
            count--;
        }

        public int GetCount()
        {
            return count;
        }
    }
}
