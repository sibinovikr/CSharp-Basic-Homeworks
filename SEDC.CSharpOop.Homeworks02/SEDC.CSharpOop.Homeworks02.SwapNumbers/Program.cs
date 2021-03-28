using System;

namespace SEDC.CSharpOop.Homeworks02.SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Input the First Number: ");

            int inputNum1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Second Number: ");

            int inputNum2 = Convert.ToInt32(Console.ReadLine());

            int temp = inputNum1;

            inputNum1 = inputNum2;

            inputNum2 = temp;

            Console.WriteLine("After Swapping: ");

            Console.WriteLine("First Number: " + inputNum1);

            Console.WriteLine("Second Number: " + inputNum2);

            Console.ReadLine();
        }
    }
}
