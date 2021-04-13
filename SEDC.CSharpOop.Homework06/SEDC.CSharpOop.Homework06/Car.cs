using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpOop.Homework06
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }
        
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public int CalculateSpeed(Driver driver)
        {
            // instantiate total speed
            int totalspeed = -1;

            // calculate total speed
            try
            {
                totalspeed = driver.Skill * Speed;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return totalspeed;
        }

    }
}
