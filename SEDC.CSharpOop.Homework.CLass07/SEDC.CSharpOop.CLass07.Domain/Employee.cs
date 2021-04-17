using System;

namespace SEDC.CSharpOop.CLass07.Domain
{
    public class Employee
    {
        public Employee()
        {

        }

        public Employee(string firstName, string lastName, Role role, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Role = role;
            this.Salary = salary;
            
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public string PrintInfo()
        {
            return $"Employee {FirstName } {LastName }: {Salary}";
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
