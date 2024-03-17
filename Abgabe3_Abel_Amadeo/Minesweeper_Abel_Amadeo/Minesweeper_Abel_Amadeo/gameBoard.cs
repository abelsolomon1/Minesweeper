using System;

namespace Minesweeper_Abel_Amadeo
{
    internal class GameBoard
    {
        private Field[,] gameBoard;
        private int width;
        private int height;
        private int mines;
        private FlagCounter flagCounter;

        public GameBoard(int width, int height, int mines)
        {
            this.width = width;
            this.height = height;
            this.mines = mines;
            gameBoard = new Field[width, height];
            flagCounter = new FlagCounter(mines);

            // Initialisiere das Spielfeld mit Feldern
            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < height; col++)
                {
                    gameBoard[row, col] = new Field();
                }
            }

            // Platziere Minen zufällig
            Random random = new Random();
            int minesToPlace = mines;
            while (minesToPlace > 0) 
            {
                int randomRow = random.Next(0, width);
                int randomCol = random.Next(0, height);
                if (!gameBoard[randomRow, randomCol].IsMine())
                {
                    gameBoard[randomRow, randomCol].SetMine();
                    minesToPlace--;
                }
            }
        }

        public void Reveal(int x, int y)
        {
            if (x >= 0 && x < width && y >= 0 && y < height && !gameBoard[x, y].IsRevealed())
            {
                gameBoard[x, y].Reveal();
                // Implementiere die Enthüllungslogik hier, z.B. rekursives Enthüllen von benachbarten Feldern
            }
        }

        public void Flag(int x, int y)
        {
            if (x >= 0 && x < width && y >= 0 && y < height && !gameBoard[x, y].IsRevealed())
            {
                gameBoard[x, y].ToggleFlag();
                if (gameBoard[x, y].IsFlagged())
                {
                    flagCounter.DecreaseCount();
                }
                else
                {
                    flagCounter.IncreaseCount();
                }
            }
        }
    }
}
