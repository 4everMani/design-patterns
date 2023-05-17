using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Example1
{
    public class CompositeEmployee : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }

        public List<IEmployee> subordinates { get; set; }

        public CompositeEmployee(string name, string department, string designation)
        {
            Name = name;
            Department = department;
            Designation = designation;
            subordinates = new List<IEmployee>();
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Employee Name: {Name}, Designation: {Designation}, Department: {Department}");
            Console.WriteLine();
            subordinates.ForEach(emp => emp.DisplayDetails());
        }

        public void AddSubordinate(IEmployee employee)
        {
            subordinates.Add(employee);
        }

        public void RemoveSubordinate(IEmployee employee)
        {
            subordinates.Remove(employee);
        }
    }
}
