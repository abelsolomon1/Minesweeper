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

        /* public Model(IDifficulty difficulty)
         {

         }*/

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
            Field[,] gameBoard = new Field[8, 8];

            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    gameBoard[row, column] = new Field();
                }
            }

            // Platziere die Minen
            Random rnd = new Random();
            int minesToPlace = 16;
            while (minesToPlace > 0)
            {
                int x = rnd.Next(0, 8);
                int y = rnd.Next(0, 8);
                if (!gameBoard[x, y].IsMine())
                {
                    gameBoard[x, y].SetMine();
                    minesToPlace--;
                }
            }

            // Ausgabe des Spielbretts
            Console.WriteLine("  1   2   3   4   5   6   7   8");
            for (int row = 0; row < 8; row++)
            {
                Console.Write((char)('A' + row) + " ");
                for (int column = 0; column < 8; column++)
                {
                    if (gameBoard[row, column].IsRevealed())
                    {
                        if (gameBoard[row, column].IsMine())
                            Console.Write("X   ");
                        else
                            Console.Write("O   ");
                    }
                    else
                    {
                        Console.Write("#   ");
                    }
                }
                Console.WriteLine();
            }
            // Spielerinteraktion
            Console.WriteLine("Geben Sie die Koordinaten des Feldes ein, das Sie aufdecken möchten (z.B. A5):");
            string input = Console.ReadLine();


            if (input.Length == 2 && char.IsLetter(input[0]) && char.IsDigit(input[1]))
            {
                int column = input[0] - 'A';
                int row = input[1] - '1';


                if (row >= 0 && row < 8 && column >= 0 && column < 8)
                {

                    gameBoard[row, column].Reveal();

                    Console.WriteLine("  1   2   3   4   5   6   7   8");
                    for (int i = 0; i < 8; i++)
                    {
                        Console.Write((char)('A' + i) + " ");
                        for (int j = 0; j < 8; j++)
                        {
                            if (gameBoard[i, j].IsRevealed())
                            {
                                if (gameBoard[i, j].IsMine())
                                    Console.Write("X   "); // Mienen
                                else
                                    Console.Write("O   "); // leere felder
                            }
                            else
                            {
                                Console.Write("#   ");//verdeckte felder
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Koordinaten. Bitte geben Sie Koordinaten innerhalb des Spielbretts ein.");
                }
            }
            else
            {
                Console.WriteLine("Ungültiges Eingabeformat. Bitte geben Sie die Koordinaten im Format 'A5' ein.");
            }

            GameBoard gameBoard2 = new GameBoard();

            gameBoard2.Reveal();
        }




        public void InitFieldsMediumMode()
        {
            Field[,] gameBoard = new Field[16, 16];

            for (int column = 0; column < 16; column++)
            {
                for (int row = 0; row < 16; row++)
                {
                    gameBoard[row, column] = new Field();
                }
            }

            // Platziere die Minen
            Random rnd = new Random();
            int minesToPlace = 40;
            while (minesToPlace > 0)
            {
                int x = rnd.Next(0, 16);
                int y = rnd.Next(0, 16);
                if (!gameBoard[x, y].IsMine())
                {
                    gameBoard[x, y].SetMine();
                    minesToPlace--;
                }
            }

            // Ausgabe des Spielbretts
            Console.WriteLine("  1   2   3   4   5   6   7   8   9  10  11  12  13  14  15  16");
            for (int column = 0; column < 16; column++)
            {
                Console.Write((char)('A' + column) + " ");
                for (int row = 0; row < 16; row++)
                {
                    if (gameBoard[row, column].IsRevealed())
                    {
                        if (gameBoard[row, column].IsMine())
                            Console.Write("X   ");
                        else
                            Console.Write("O   ");
                    }
                    else
                    {
                        Console.Write("#   ");
                    }
                }
                Console.WriteLine();
            }

            // Spielerinteraktion
            Console.WriteLine("Geben Sie die Koordinaten des Feldes ein, das Sie aufdecken möchten (z.B. A5):");
            string input = Console.ReadLine();

            if (input.Length == 2 && char.IsLetter(input[0]) && char.IsDigit(input[1]))
            {
                int column = input[0] - 'A';
                int row = input[1] - '1';

                if (row >= 0 && row < 16 && column >= 0 && column < 16)
                {
                    gameBoard[row, column].Reveal();

                    Console.WriteLine("  1   2   3   4   5   6   7   8   9  10  11  12  13  14  15  16");
                    for (int i = 0; i < 16; i++)
                    {
                        Console.Write((char)('A' + i) + " ");
                        for (int j = 0; j < 16; j++)
                        {
                            if (gameBoard[i, j].IsRevealed())
                            {
                                if (gameBoard[i, j].IsMine())
                                    Console.Write("X   ");
                                else
                                    Console.Write("O   ");
                            }
                            else
                            {
                                Console.Write("#   ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Koordinaten. Bitte geben Sie Koordinaten innerhalb des Spielbretts ein.");
                }
            }
            else
            {
                Console.WriteLine("Ungültiges Eingabeformat. Bitte geben Sie die Koordinaten im Format 'A5' ein.");
            }

            GameBoard gameBoard2 = new GameBoard();

            gameBoard2.Reveal();
        }

        public void InitFieldsHardMode()
        {
            Field[,] gameBoard = new Field[16, 30];

            for (int row = 0; row < 16; row++)
            {
                for (int column = 0; column < 30; column++)
                {
                    gameBoard[row, column] = new Field();
                }
            }

            // Platziere die Minen
            Random rnd = new Random();
            int minesToPlace = 99;
            while (minesToPlace > 0)
            {
                int x = rnd.Next(0, 16);
                int y = rnd.Next(0, 30);
                if (!gameBoard[x, y].IsMine())
                {
                    gameBoard[x, y].SetMine();
                    minesToPlace--;
                }
            }

            // Ausgabe des Spielbretts
            Console.WriteLine("  1   2   3   4   5   6   7   8   9  10  11  12  13  14  15  16  17  18  19  20  21  22  23  24  25  26  27  28  29  30");
            for (int row = 0; row < 16; row++)
            {
                Console.Write((char)('A' + row) + " ");
                for (int column = 0; column < 30; column++)
                {
                    if (gameBoard[row, column].IsRevealed())
                    {
                        if (gameBoard[row, column].IsMine())
                            Console.Write("X   ");
                        else
                            Console.Write("O   ");
                    }
                    else
                    {
                        Console.Write("#   ");
                    }
                }
                Console.WriteLine();



            }

            // Spielerinteraktion
            Console.WriteLine("Geben Sie die Koordinaten des Feldes ein, das Sie aufdecken möchten (z.B. A5):");
            string input = Console.ReadLine();

            if (input.Length == 2 && char.IsLetter(input[0]) && char.IsDigit(input[1]))
            {
                int column = input[0] - 'A';
                int row = input[1] - '1';

                if (row >= 0 && row < 16 && column >= 0 && column < 30)
                {
                    gameBoard[row, column].Reveal();

                    Console.WriteLine("  1   2   3   4   5   6   7   8   9  10  11  12  13  14  15  16  17  18  19  20  21  22  23  24  25  26  27  28  29  30");
                    for (int i = 0; i < 16; i++)
                    {
                        Console.Write((char)('A' + i) + " ");
                        for (int j = 0; j < 30; j++)
                        {
                            if (gameBoard[i, j].IsRevealed())
                            {
                                if (gameBoard[i, j].IsMine())
                                    Console.Write("X   ");
                                else
                                    Console.Write("O   ");
                            }
                            else
                            {
                                Console.Write("#   ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Koordinaten. Bitte geben Sie Koordinaten innerhalb des Spielbretts ein.");
                }
            }
            else
            {
                Console.WriteLine("Ungültiges Eingabeformat. Bitte geben Sie die Koordinaten im Format 'A5' ein.");
            }

            GameBoard gameBoard2 = new GameBoard();

            gameBoard2.Reveal();
        }

    }

}

