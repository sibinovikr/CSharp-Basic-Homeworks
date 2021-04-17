using System;
using SEDC.CSharpOop.CLass07.Domain;

namespace SEDC.CSharpOop.CLass07.Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee theEmployee = new Employee("Poppy", "Willson", Role.Other, 400);
            theEmployee.PrintInfo();      
                       
            SalesPerson salesEmployee = new SalesPerson("John", "Doe", 500);
            salesEmployee.AddSuccessRevenue(2000);
            salesEmployee.PrintInfo();            
                        
            Manager managerEmployee = new Manager("Emily", "Johnson", 2000);
            managerEmployee.AddBonus(500);
            managerEmployee.PrintInfo();                  
        
            Console.ReadLine();
        }
    }
}
