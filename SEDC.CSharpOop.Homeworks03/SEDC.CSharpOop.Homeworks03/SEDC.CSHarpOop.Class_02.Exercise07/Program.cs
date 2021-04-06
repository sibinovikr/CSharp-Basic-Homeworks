using System;

namespace SEDC.CSHarpOop.Class_02.Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number from 1 to 3: ");
            string inputNumber = Console.ReadLine();

            switch (inputNumber)
            {
                case "1":
                    Console.WriteLine("You got a new car!");
                    break;
                case "2":
                    Console.WriteLine("You got a new plane!");
                    break;
                case "3":
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("Please enter a valid number!");
                    break;
            }
        }
    }
}
