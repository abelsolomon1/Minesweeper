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

    Console.WriteLine("Which field do you want to reveal? Example: A5 ");

    string input = Console.ReadLine();

    
    if (input.Length != 2 || !char.IsLetter(input[0]) || !char.IsDigit(input[1]))
    {
        Console.WriteLine("Invalid input. Please enter coordinates in the format 'LetterNumber' (e.g. A5).");
        return;
    }


    int column = input[0] - 'A';

  
    int row;
    if (!int.TryParse(input[1].ToString(), out row))
    {
        Console.WriteLine("Invalid input. Please enter coordinates in the format 'LetterNumber' (e.g. A5).");
        return;
    }
    row--; 

    
    if (row < 0 || row >= gameBoard.GetLength(0) || column < 0 || column >= gameBoard.GetLength(1))
    {
        Console.WriteLine("Invalid coordinates. Please enter coordinates within the game board.");
        return;
    }

    if (gameBoard[row, column].IsMine())
    {
        Console.WriteLine("GAME OVER");
        
    }
    else
            {
                gameBoard[row, column].Reveal();

              
                RevealNeighbouredFields(row, column);
            }
}


        // Methode zum Aufdecken benachbarter Felder
        private void RevealNeighbouredFields(int row, int column)
        {
            int numRows = gameBoard.GetLength(0);
            int numColumns = gameBoard.GetLength(1);

            for (int r = Math.Max(0, row - 1); r <= Math.Min(row + 1, numRows - 1); r++)
            {
                for (int c = Math.Max(0, column - 1); c <= Math.Min(column + 1, numColumns - 1); c++)
                {
                    if (!gameBoard[r, c].IsRevealed())
                    {
                        // Feld aufdecken
                        gameBoard[r, c].Reveal();
                    }
                }
            }
        }

        public void Flag()
        {
            //Hier muss die logik noch implementiert werden(optional)
        }
    }
}
