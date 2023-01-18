using System;

namespace Mission2
{
    public class Program
    {
        public static void Main(string[] args)
        
        {
            Random r = new Random(); //brings in the Random library
            int numRolls; //creates the number of rolls as an integer


            // messages that will show to the reader
            Console.WriteLine("Welcome to the dice throwing simulator! \n");
            //asks for how many times to roll the dice
            Console.WriteLine("How many dice rolls would you like to simulate? \n");
            // puts that user input as the number of Rolls
            numRolls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls. \nTotal number of rolls = " + numRolls + '\n');

            int[] array = new int[13]; //array is the array

            for (int i = 0; i < 13; i++)
            {
                array[i] = 0; // This is putting a 0 in each spot of the array
            }

            for (int i = 0; i < numRolls; i++)
            {
                int roll = r.Next(2,13); //This is making the variable roll = to the random number rolled
                array[roll]++; // This is adding the roll into the correct spot of the array
            }

            for (int i = 2; i < 13; i++)
            {
                float percent = ( array[i] / (float)numRolls) * 100; // This is taking the number in the array slot and dividing it by the total number of rolls to get the percentage
                int rounded = Convert.ToInt32(Math.Round(percent)); // rounding the percent
                string output = ""; //creates the string output
                for (int f = 0; f < rounded; f++)
                {
                    output = (output + "*"); //takes the output and adds a new star to the correct number in the array
                }
                Console.WriteLine(i + ": " + output); //outputs the complete string
            }
        }
    }
}