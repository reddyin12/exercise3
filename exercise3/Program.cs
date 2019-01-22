using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 3
            // Input 3 numbers from the user (x,y,z) and find the greatest of them.

            // Write your code here

            Console.WriteLine("Enter three values seperated by comma");
            var values=Console.ReadLine();
            string[] numbers = values.Split(',');

            int num1 = int.Parse(numbers[0]);
            int num2 = int.Parse(numbers[1]);
            int num3 = int.Parse(numbers[2]);

            if (num1>num2 && num1>num3)
            {
                Console.WriteLine("number {0} is greater ", num1);
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("number {0} is greater ", num2);
            }
            else{
                Console.WriteLine("number {0} is greater ", num3);

            }

        }
    }
}
