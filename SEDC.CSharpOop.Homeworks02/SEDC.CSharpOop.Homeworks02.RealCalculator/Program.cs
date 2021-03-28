using System;

namespace SEDC.CSharpOop.Homeworks02.RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");

            int inputNum1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");

            int inputNum2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the operator: ");

            char operators = Convert.ToChar(Console.ReadLine());

            switch (operators)
            {
                case '+':
                    int result = inputNum1 + inputNum2;
                    Console.WriteLine("The result is: " + result);
                    break;

                case '-':
                    result = inputNum1 - inputNum2;
                    Console.WriteLine("The result is: " + result);
                    break;

                case '*':
                    result = inputNum1 * inputNum2;
                    Console.WriteLine("The result is: " + result);
                    break;

                case '/':
                    result = inputNum1 / inputNum2;
                    Console.WriteLine("The result is: " + result);
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
            Console.ReadLine();

        }
    }
}
