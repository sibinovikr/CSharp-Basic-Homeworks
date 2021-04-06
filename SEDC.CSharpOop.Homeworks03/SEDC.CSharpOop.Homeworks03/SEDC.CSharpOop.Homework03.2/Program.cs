using System;

namespace SEDC.CSharpOop.Homework03._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Marko", "Darko", "Bojan", "Stojan", "Martin" };

            Console.WriteLine("Enter student group: (there are 1 and 2)");

            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("The students in G1 are : ");
                for (int i = 0; i <= studentsG1.Length - 1; i++)
                {
                    Console.WriteLine(studentsG1[i]);
                }
            }
            else if (num == 2)
            {
                Console.WriteLine("The students in G2 are : ");
                for (int i = 0; i <= studentsG2.Length - 1; i++)
                {
                    Console.WriteLine(studentsG2[i]);
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the group number ");

            }
        }
    }
}
