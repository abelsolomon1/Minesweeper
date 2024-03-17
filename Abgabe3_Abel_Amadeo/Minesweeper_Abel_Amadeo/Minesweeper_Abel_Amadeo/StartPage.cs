using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_Abel_Amadeo
{
    internal class StartPage
    {
        //Deklaration
        private Menu menu;

        //Konstruktor

        public StartPage()
        {
            menu= new Menu();
        }

        //Methoden
        public void Show()
        {
            menu.ShowMenu();
        }

    }
}
