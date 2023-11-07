using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace
{
    //possible flow??
    //initialize all horses in list [DONE BTCH]
    //display all horses in list [DONE]
    //get random movement
    //check victory status for each horse in each movement
    //  if not at finish line yet,
    //      keep moving
    //  else (at finish line)
    //      break (stop the game and declare winner!!

    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize horses
            List<Horse> horses = new List<Horse>();
            horses.Add(new Horse(1, ConsoleColor.Cyan));
            horses.Add(new Horse(2, ConsoleColor.DarkYellow));
            horses.Add(new Horse(3, ConsoleColor.Blue));
            horses.Add(new Horse(4, ConsoleColor.Yellow));
            Console.WriteLine("Press any key to start race. . .");
            Console.ReadKey();
            Console.Clear();
            bool cont = true;

            while(cont)
            {
                foreach (Horse horse in horses)
                {
                    horse.move();
                }
                if (!cont)
                    break;
                Console.ReadKey();
                Console.Clear();

            }
            //Horse horse = new Horse();

            Console.ReadKey();
        }
    }
}
