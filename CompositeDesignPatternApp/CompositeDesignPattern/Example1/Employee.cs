using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Example1
{
    public class Employee : IEmployee
    {
        public string Name { get ; set ; }
        public string Department { get ; set ; }
        public string Designation { get; set ; }

        public Employee(string name, string department, string designation)
        {
            Name = name;
            Department = department;
            Designation = designation;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Employee Name: {Name}, Designation: {Designation}, Department: {Department}");
            Console.WriteLine();
        }
    }
}
