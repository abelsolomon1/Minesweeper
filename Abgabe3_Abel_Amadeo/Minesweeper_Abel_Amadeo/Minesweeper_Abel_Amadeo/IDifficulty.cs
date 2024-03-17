using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_Abel_Amadeo
{
    internal interface IDifficulty
    {
        int Width { get; set; }
        int Height { get; set; }
        int Mines { get; set; }
    }
}
