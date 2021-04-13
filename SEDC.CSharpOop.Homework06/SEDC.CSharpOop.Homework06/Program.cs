using System;

namespace SEDC.CSharpOop.Homework06
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver1 = new Driver("Bob", 5);
            Driver driver2 = new Driver("Greg", 4);
            Driver driver3 = new Driver("Jill", 7);
            Driver driver4 = new Driver("Anne", 3);

            Car carno1 = new Car("Hyndai", 220);
            Car carno2 = new Car("Mazda", 200);
            Car carno3 = new Car("Ferrari", 300);
            Car carno4 = new Car("Porsche", 260);

            Car[] cars = new Car[] { carno1, carno2, carno3, carno4 };
            Driver[] drivers = new Driver[] { driver1, driver2, driver3, driver4 };

            // Choose the first car
            Console.WriteLine($"Choose the first car: \n1. {carno1.Model} \n2. {carno2.Model} \n3. {carno3.Model} \n4. {carno4.Model} ");
            int firstcar = int.Parse(Console.ReadLine());

            // Choose the driver for the car
            Console.WriteLine($"Choose the driver for the first car: \n1. {driver1.Name} \n2. {driver2.Name} \n3. {driver3.Name} \n4. {driver4.Name} ");
            int firstdriver = int.Parse(Console.ReadLine());

            // assign driver
            cars[firstcar - 1].Driver = drivers[firstdriver - 1];

            // Choose the second car
            Console.WriteLine($"Choose the second car: \n1. {carno1.Model} \n2. {carno2.Model} \n3. {carno3.Model} \n4. {carno4.Model} ");
            int secondcar = int.Parse(Console.ReadLine());

            // Choose the driver for the car
            Console.WriteLine($"Choose the driver for the second car: \n1. {driver1.Name} \n2. {driver2.Name} \n3. {driver3.Name} \n4. {driver4.Name} ");
            int seconddriver = int.Parse(Console.ReadLine());

            // assign driver
            cars[secondcar - 1].Driver = drivers[seconddriver - 1];

            // Race the cars
            RaceCars(cars[firstcar - 1], cars[secondcar - 1]);


            Console.ReadLine();
        }




        public static void RaceCars(Car no1, Car no2)
        {

            if (no1.Speed > no2.Speed)
            {
                Console.WriteLine("The winner is " + no1.Model);
            }
            else if (no2.Speed > no1.Speed)
            {
                Console.WriteLine("The winner is " + no2.Model);
            }
            else
            {
                Console.WriteLine("Both share the first place, beacuse they were moving with the same speed.");
            }

        }
    }
}
