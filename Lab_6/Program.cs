using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string check;

            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n): ");

            while (true)
            {
                //vars
                string dSides;
                int sides;
                int rollResult1;
                int rollResult2;
                Random rnd = new Random();
                //get sides
                Console.Write("How many sides should each die have? ");
                dSides = Console.ReadLine();
                sides = int.Parse(dSides);


                //Call method getRoll Spit results
                rollResult1 = GetRoll(sides, rnd);
                rollResult2 = GetRoll(sides, rnd);

                Console.WriteLine("Roll: ");
                Console.WriteLine(rollResult1);
                Console.WriteLine(rollResult2);

                //verify for craps




                //Check
                Console.Write("Continue y/n: ");
                check = Console.ReadLine();
                if (check != "y")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
        //method
        public static int GetRoll(int x, Random randomNumber)
        {

            int y = randomNumber.Next(1, (x + 1));

            return (y);
            
        }

    }
}
