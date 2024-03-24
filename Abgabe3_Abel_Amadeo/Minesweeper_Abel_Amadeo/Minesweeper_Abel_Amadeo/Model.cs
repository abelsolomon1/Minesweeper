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

        public void InitFieldsEasyMode()
        {
            char[,] gameBoard = new char[8, 8];

            // Fülle das Spielbrett mit #
            for (int column = 0; column < 8; column++)
            {
                for (int row = 0; row < 8; row++)
                {
                    gameBoard[row, column] = '#';
                }
            }

            // Ausgabe des Spielbretts
            Console.WriteLine(" 1  2  3  4  5  6  7  8");
            for (int column = 0; column < 8; column++)
            {
                Console.Write((char)('A' + column) + " ");
                for (int row = 0; row < 8; row++)
                {
                    Console.Write(gameBoard[row, column] + "   ");
                }
                Console.WriteLine();
            }
        }

        public void InitFieldsMediumMode()
        {
            char[,] gameBoard = new char[16, 16];

            // Fülle das Spielbrett mit #
            for (int column = 0; column < 16; column++)
            {
                for (int row = 0; row < 16; row++)
                {
                    gameBoard[row, column] = '#';
                }
            }

            // Ausgabe des Spielbretts
            Console.WriteLine("  1   2   3   4   5   6   7   8   9  10  11  12  13  14  15  16");
            for (int column = 0; column < 16; column++)
            {
                Console.Write((char)('A' + column) + " ");
                for (int row = 0; row < 16; row++)
                {
                    Console.Write(gameBoard[row, column] + "   ");
                }
                Console.WriteLine();
            }
        }

        public void InitFieldsHardMode()
        {
            char[,] gameBoard = new char[16, 30];

            // Fülle das Spielbrett mit #
            for (int column = 0; column < 30; column++)
            {
                for (int row = 0; row < 16; row++)
                {
                    gameBoard[row, column] = '#';
                }
            }

            // Ausgabe des Spielbretts
            Console.WriteLine(" 1   2   3   4   5   6   7   8   9  10  11  12  13  14  15  16  17  18  19  20  21  22  23  24  25  26  27  28  29  30");
            for (int column = 0; column < 30; column++)
            {
                Console.Write((char)('A' + column) + " ");
                for (int row = 0; row < 16; row++)
                {
                    Console.Write(gameBoard[row, column] + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}
