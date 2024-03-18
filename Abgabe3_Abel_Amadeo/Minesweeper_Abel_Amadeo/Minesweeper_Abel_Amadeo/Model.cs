using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_Abel_Amadeo
{
    internal class Model 
    {
        private GameState gameState;
        private Caretaker careTaker;
        private StartPage startPage;
        private Menu menu;
        private Rules rules;
        private IDifficulty idifficulty;
        private Model model;
        private FlagCounter flagCounter;
        private GameBoard gameBoard;

        private int[,] field;
        private int width;
        private int height;

        public Model(IDifficulty difficulty)
        {

        }

        public Model()
        {
        }

        public void Start()
        {
            Menu menu = new Menu();
            menu.selectDifficulty();
            
        }

        public void CheckForWin()
        {

        }

        public void CheeckForLoss()
        {
            
        }

        public void InitFields()
        {
            
        }

        public int GetField(int x, int y)
        {
            return x + y; //vorüberläufig da sonst fehlermeldungen auftauchen.
        }
    }
}
