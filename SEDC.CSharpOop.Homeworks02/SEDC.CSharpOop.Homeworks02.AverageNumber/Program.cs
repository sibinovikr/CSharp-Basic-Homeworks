using System;

namespace SEDC.CSharpOop.Homeworks02.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");

            int inputNum1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");

            int inputNum2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");

            int inputNum3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the fourth number: ");

            int inputNum4 = Convert.ToInt32(Console.ReadLine());

            double result = Convert.ToDouble(inputNum1 + inputNum2 + inputNum3 + inputNum4) / 4;

            Console.WriteLine("The average of numbers: " + inputNum1 + ", " + inputNum2 + ", " + inputNum3 + ", " + inputNum4 + " is: " + result);

            Console.ReadLine();

        }
    }
}
