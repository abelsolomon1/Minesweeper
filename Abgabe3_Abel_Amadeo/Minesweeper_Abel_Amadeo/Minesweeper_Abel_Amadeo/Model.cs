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
            idifficulty = difficulty;
           // width = idifficulty.GetWidth();
           // height = idifficulty.GetHeight();
            InitFields();
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
            field = new int[width, height];
        }

        public int GetField(int x, int y)
        {
            Console.WriteLine("Enter the coordinates of the field you want to check:");
            Console.Write("Enter the x-coordinate: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Enter the y-coordinate: ");
            y = int.Parse(Console.ReadLine());

            if (x < 0 || x >= width || y < 0 || y >= height)
            {
                throw new ArgumentException("Coordinates are out of bounds.");
            } else
            {

            }

            return field[x, y];
        }
    }
}
