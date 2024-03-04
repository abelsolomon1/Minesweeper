namespace Minesweeper.Logic
{
    public class Model
    {
        private Field[,] gameboard; //[,] = Zweidimensionales Array
        public Model(int xsize, int ySize)
        {
            this.gameboard = new Field[xsize, ySize];
        }

        public void DoTurn(string coordinate)
        {
            

        }

    }

    public class Field
    {
        public int anzahlMienenInDerNaehe;

    }
}