using System;

namespace comp123_bonus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             COMP123 - Bonus 1
             STUDENT: Fan Yang (301295721)

             1 - In the Main() method it reads in a list of integers from the user, separated by commas.
             2 - Send the list of integers as a single string to a new method you will create which has a parameter of type string.
             3 - Your new method should then calculate and print out the sum and average of the integers in the list. 
                 The program should handle the case where the user enters an empty list (i.e., just hits enter without entering any integers). 
                 You can give an error message in this case
             */


            Console.WriteLine("================================================");
            Console.WriteLine("||               COMP123 - Bonus 1            ||");
            Console.WriteLine("================================================\n");

            Console.WriteLine("Please enter a list of integers separated by commas: ");
            string userInputStr = Console.ReadLine();

            if (userInputStr.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: The integer list is empty, exit the application.");
                Console.ResetColor();
                return;
            }

            string[] userInputStrArray = userInputStr.Split(',');
            int[] userInputIntArray = strArrarToIntArray(userInputStrArray);
            int sum = calculateSum(userInputIntArray);
            double average = calculateAverage(userInputIntArray);

            Console.WriteLine($"Sum: {sum} | Average: {average}");
        }
        public static int[] strArrarToIntArray( string[] strArray) {
            int[] intArray = Array.ConvertAll(strArray, Int32.Parse);
            return intArray;
        }

        public static int calculateSum( int[] intArray) {
            int sumResult = 0;
            foreach (int number in intArray) {
                sumResult = sumResult + number;
            }
            return sumResult; 
        }

        public static double calculateAverage( int[] intArray) {

            double sumInDouble = Convert.ToDouble(calculateSum(intArray));
            double averageResult = sumInDouble / intArray.Length;
            averageResult = (double)System.Math.Round(averageResult, 2);
            return averageResult;
        }

    }
}
