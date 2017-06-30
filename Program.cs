using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
{
        static Random rdm = new Random();

        static void Main()
        {
            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? Y/N");
            string roll = Console.ReadLine();
            bool run = true;

            if ((roll == "n") || (roll == "N"))
            {
                Console.WriteLine("OK, maybe next time :)");
            }

            else
            {
                while (run == true)
                {
                    Console.WriteLine("How many sides should the dice have?");
                    int input = int.Parse(Console.ReadLine());
                    int Dice1 = getRandom(input);
                    int Dice2 = getRandom(input);
                    Console.WriteLine(Dice1);
                    Console.WriteLine(Dice2);
                    run = Continue();
                }
            }
        }
        public static int getRandom(int x)
        {

            int randnum = rdm.Next(0, x);
            return randnum;


        }
        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Roll Again? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("I'm sorry I don't understand. Let's try again");
                run = Continue();
            }
            return run;
        }

    }

}
