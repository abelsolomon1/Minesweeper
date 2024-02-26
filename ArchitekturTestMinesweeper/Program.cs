using Minesweeper.Logic;

namespace Minesweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var model = new Model(16, 16);

            while (true)
            {
                Console.Clear();
                // Write Model to console
                Console.WriteLine("Bitte Koordinate eingeben");
                var coordinate = Console.ReadLine();
                model.DoTurn(coordinate);
            }


        }
    }
}