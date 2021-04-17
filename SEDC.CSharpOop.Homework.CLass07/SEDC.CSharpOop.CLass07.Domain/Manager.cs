﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpOop.CLass07.Domain
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Manager(string firstName, string lastName, double salary) : base(firstName, lastName, Role.Manager, salary)
        {
           
        }

        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
