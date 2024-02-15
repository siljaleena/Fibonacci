namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*In mathematics, the Fibonacci sequence is a sequence in which each number is the sum of the two preceding ones. 
             * Numbers that are part of the Fibonacci sequence are known as Fibonacci numbers, commonly denoted Fn . 
            The sequence commonly starts from 0 and 1, although some authors start the sequence from 1 and 1 or sometimes (as did Fibonacci) from 1 and 2. Starting from 0 and 1, 
            the sequence begins 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ....*/

            //asks the user to input the length of the Fibonacci series
            Console.WriteLine("Display the n number Fibonacci series");
            Console.Write("Input a number: ");

            //reads the input and stores it in the 'length' integer
            int length = int.Parse(Console.ReadLine());

            //calls the display method and shows the answer
            display(length);
            
        }
        //this is the method that gets called to show the answer
        static void display(int length)
        {
            //initializes the first two numbers
            int firstNumber = 0, secondNumber = 1;

            //displays the first two numbers
            Console.Write($"The Fibonacci series of number {length} is: {firstNumber} {secondNumber}");

            //this loop generates the rest of the numbers
            for (int sum = 2; sum < length; sum++)
            {
                //calculates the next number by adding the previous two numbers and then displays it
                int nextNumber = firstNumber + secondNumber;
                Console.Write($" {nextNumber}");

                //updates the first and second numbers for the next iteration
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
            Console.ReadLine();
        }
    }
}