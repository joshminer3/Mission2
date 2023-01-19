using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an int variable for the number of throws and a variable for the array
            int throwNum = 0;
            int placeNum = 0;

            //Variable to create the random number
            Random r = new Random();

            //Create array with 11 places and assigning the values 2-12
            int[] blah = new int[10];

            for (int i = 0; i < 10; i++)
            {
       
                blah[i] = placeNum;

                //placeNum += 1;

            }

            //Greeting
            Console.WriteLine("Welcome to Dice Throwing Simulator");

            //Prompt the user to enter the number of times to roll
            Console.Write("How many times would you like to throw the dice? ");
            throwNum = int.Parse(Console.ReadLine());


            //For Loop to add to the array if the random number was rolled
            for (int i = 0; i <throwNum; i++)
            {
                blah[r.Next(10)]++;
            }


            //Explain to User the results of the game
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls");
            Console.WriteLine("Total Numer of Rolls = " + throwNum);

            //Display Array
            foreach (var item in blah)
            {
                Console.WriteLine(item.ToString());
            }


        }
    }
}
