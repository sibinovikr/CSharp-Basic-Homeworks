using System;

namespace SEDC.CSharpOop.Homework03._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] myArray = new int[6];            
            Console.WriteLine("Enter integer no.1: ");
            myArray[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer no.2: ");
            myArray[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer no.3: ");
            myArray[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer no.4: ");
            myArray[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer no.5: ");
            myArray[4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer no.6: ");
            myArray[5] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected output: ");
            for (int i = 0; i <= myArray.Length - 1; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    sum += myArray[i];
                }
            }
            Console.WriteLine(sum);

        }
    }
    
}
