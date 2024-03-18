using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_Abel_Amadeo
{
    internal class Menu
    {
        



        //Methoden 
       
        public void ShowMenu()
        {
            Console.WriteLine("Welcome to Minesweeper!");
            while (true)
            {
                Console.WriteLine("1. Start Game");
                Console.WriteLine("2. Show Rules");
                Console.WriteLine("3. Exit");
                Console.Write("Please enter your choice: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Model model = new Model();
                        model.Start();
                        break;
                    case "2":
                        Rules rules = new Rules();
                        rules.showRules();
                        break;
                    case "3":
                        Console.WriteLine("Bye...");
                        Environment.Exit(0);

                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;



                }
            }
            
        }
        public IDifficulty selectDifficulty()
        {
            Console.WriteLine("Select Difficulty:");
            while (true)
            {
                Console.WriteLine("1. Easy");
                Console.WriteLine("2. Medium");
                Console.WriteLine("3. Hard");
                Console.Write("Please enter your Choice: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        return new EasyMode(8, 8, 10);
                        

                    case "2":
                        return new MediumMode(16, 16, 40);

                    case "3":
                        return new HardMode(16, 30, 99);
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option");
                        break; 
                }
            }
            
        }

        //KeyBinds 
        public static readonly char RevealKey = 'r';
        public static readonly char FlagKey = 'f';
        public static readonly char UndoKey = 'u';

        public void setKeyBinds()
        {
            Console.WriteLine("Key Binds:");
            Console.WriteLine($"Reveal Key: {RevealKey}");
            Console.WriteLine($"Flag Key: {FlagKey}");
            Console.WriteLine($"Undo Key: {UndoKey}");

        }
    }
}
