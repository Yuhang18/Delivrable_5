/*
 Author: Yuhang Bai
 Date: 2/16/2023
 Comment: This C# Console application code demostrates the use of methods after getting input from users
*/

using System;

namespace Methods_Application
{
    class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] Myarray = new int[array_len];
            for (int i = 0; i < array_len; i++) 
            {
                Myarray[i] = random.Next(10,50);
            }
            return Myarray;
        }
        
        static int sum(int[] array)
        {
            int sum = 0;
            foreach(int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 5 and 15");
            try
            {

                int input = int.Parse(Console.ReadLine());

                int[] sampleArray = random_array(input);

                Console.WriteLine("The elements in the random array are: ");
                foreach (int element in sampleArray)
                {
                    Console.Write(element + " ");
                }

                Console.WriteLine(" ");
                Console.WriteLine("The sum is: " + sum(sampleArray));

            }
            catch (FormatException)
            {
                Console.WriteLine("The input is not a valid integer");
            }
        }
    }
}