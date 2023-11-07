using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace
{
    internal class Horse
    {
        private int hNum = 0;
        private int hPos = 0;
        private ConsoleColor hColor;
        static Random rnd = new Random();
        private string hName = "";
        public Horse(int num, ConsoleColor color) 
        { 
            hNum = num;
            hColor = color;
            hName = hNum.ToString();
            while(hName.Length != 3)
                hName = "0" + hName;
            displayHorses();
        }
        public void displayHorses()
        {
            Console.ForegroundColor = hColor;
            Console.Write($"{hName}: ");
            Console.Write(new string(' ', hPos) + "X");
            Console.WriteLine(new string(' ', 40)/* + "|"*/);
            Console.ResetColor();
        }
        public void move()
        {
            int hMove = 0;
            int hStep = 0;
            
            hMove = rnd.Next(1, 4);

            hStep = rnd.Next(0, 2);

            if(hStep == 0)
                hPos -= hMove;
            else
                hPos += hMove;

            if (hPos < 0)
                hPos = 0;
            else if (hStep > 40)
                hPos = 40;
            
            displayHorses();
            //starts the game
            //this will call methods that will:
            //  get random number for movement so X will ++ or --
            //  display updated horse movements

        }
    }
}
