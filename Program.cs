﻿namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*In mathematics, the Fibonacci sequence is a sequence in which each number is the sum of the two preceding ones. 
             * Numbers that are part of the Fibonacci sequence are known as Fibonacci numbers, commonly denoted Fn . 
            The sequence commonly starts from 0 and 1, although some authors start the sequence from 1 and 1 or sometimes (as did Fibonacci) from 1 and 2. Starting from 0 and 1, 
            the sequence begins 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ....*/

            Console.WriteLine("Display the n number Fibonacci series");
            Console.Write("Input a number: ");

            int length = int.Parse(Console.ReadLine());

            display(length);
            
        }

        static void display(int length)
        {
            int firstNumber = 0, secondNumber = 1;

            Console.Write($"The Fibonacci series of number {length} is: {firstNumber} {secondNumber}");

            for (int sum = 2; sum < length; sum++)
            {
                int nextNumber = firstNumber + secondNumber;
                Console.Write($" {nextNumber}");

                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}