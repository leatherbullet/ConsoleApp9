using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            int tempNumber;
            int userInput;
            int shift;
            
            foreach (int number in numbers)
                Console.Write(number + " ");

            Console.WriteLine("\nна сколько позиций влево хотите сместить?");
            userInput = Convert.ToInt32(Console.ReadLine());

            shift = userInput % number.Length
            
            for (int i = 0; i < shift; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    tempNumber = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = tempNumber;
                }
            }

            foreach (int number in numbers)
                Console.Write(number + " ");
        }
    }
}
