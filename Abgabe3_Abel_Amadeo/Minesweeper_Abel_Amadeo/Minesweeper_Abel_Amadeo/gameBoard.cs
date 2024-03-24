using System;

namespace Minesweeper_Abel_Amadeo
{
    internal class GameBoard
    {
        private Field[,] gameBoard;
        private int width;
        private int height;
        private int mines;
        


        

        public void Reveal()
        {
            Menu menu = new Menu();

            string revealInput = Console.ReadLine();
            if (revealInput != null )
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                //Aufdecken des Feldes (Felder und Mienen wurden noch nicht generiert)
            }
        }

        public void Flag()
        {
        
        }
    }
}
