/*
Author: Andrew Sabourin
Date: 10/01/2025
Assignment: PA2
*/
    namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task2 Part 1
            #region Task2 Part 1
            //Declare int variable and set to max value
            int maxValue = int.MaxValue;

            //Print the value of both as a normal int and as a Hex format
            Console.WriteLine($"Max Int: {maxValue}");
            Console.WriteLine($"Max Int in Hex: {maxValue:X}");

            // Increment the varuable by one (causing an overflow)
            maxValue++;
            Console.WriteLine($"\nAfter Incrementing by 1");
            Console.WriteLine($"Int Value: {maxValue}");
            Console.WriteLine($"Int Value in Hex: {maxValue:X}");

            // Set the variable to 0 and print its value
            maxValue = 0;
            Console.WriteLine($"\nSet to 0:");
            Console.WriteLine($"Int Value: {maxValue}");
            Console.WriteLine($"Int Value: {maxValue:X}");

            // Decrement the variable by 1 (causing an underflow)
            maxValue--;
            Console.WriteLine($"\nAfter Decrementing by 1:");
            Console.WriteLine($"Int Value: {maxValue}");
            Console.WriteLine($"Int Value: {maxValue:X}");
            #endregion

            // Casting section
            #region
            // Assign the max value to your int variable
            int intValue = int.MaxValue;

            // Declare a short variable and initialize its value to the int variable using casting
            short shortValue = (short)intValue;

            // Print the int cariable as a number and in the Hex format
            Console.WriteLine($"\nCasting Section:");
            Console.WriteLine($"Int Value: {maxValue}");
            Console.WriteLine($"Int Value: {maxValue:X}");

            // Print the short variable as a number and in the Hex format
            Console.WriteLine($"Short Value: {shortValue}");
            Console.WriteLine($"Short Value: {shortValue:X}");
            #endregion

            // Task 3 Arrays and Loops
            #region Loops
            // Declare an array of ints of size 5
            int[] numbers = new int[5];

            // Use a for loop to populate the array with values 1-5
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            // Use a foreach loop to print the array values in a single line
            Console.WriteLine("\nArray Values:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            #endregion

            // Task 3 Bonus: multiplication table
            #region Bonus Loop
            Console.WriteLine("\nMultiplication Table 1-5:");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
            #endregion

            // Task 4: Printer Troubleshooter Program
            #region Printer troubleshooter
            string condition = "";

            // Ask the first question
            Console.WriteLine("\nIs the printer on? (Y/N)");
            string answer1 = Console.ReadLine();
            condition += answer1.ToUpper() == "Y" ? "Y" : "N";

            // Ask second question
            Console.WriteLine("\nDoes the printer have paper? (Y/N)");
            string answer2 = Console.ReadLine();
            condition += answer2.ToUpper() == "Y" ? "Y" : "N";

            // Ask the first question
            Console.WriteLine("\nIs there a paper jam? (Y/N)");
            string answer3 = Console.ReadLine();
            condition += answer3.ToUpper() == "Y" ? "Y" : "N";

            // Print the condition variable 
            //Console.WriteLine($"\nCondition: {condition}");

            // Switch statement with troubleshooting steps
            switch (condition)
            {       case "YYY":
                    Console.WriteLine("\nCheck the printer display for any error messages.");
                    break;
                case "YYN":
                    Console.WriteLine("\nCheck for other Issues");
                    break;
                case "YNY":
                    Console.WriteLine("\nClear jammed paper, add paper to the printer, and try printing again.");
                    break;
                case "YNN":
                    Console.WriteLine("\nAdd paper to the printer...");
                    break;
                case "NYY":
                    Console.WriteLine("\nTurn on the printer and check roll compartment");
                    break;
                case "NYN":
                    Console.WriteLine("\nTurn on the printer...");
                    break;
                case "NNY":
                    Console.WriteLine("\nTurn on the printer and check roll compartment... its jammed");
                    break;
                case "NNN":
                    Console.WriteLine("\nTurn on the printer, add paper to the printer, clear any paper jams, and try printing again.");
                    break;
                default:
                    Console.WriteLine("\nInvalid input. Please answer with 'Y' or 'N'.");
                    break;
            }
            #endregion
        }
    }
}
