using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Example1
{
    public interface IEmployee
    {
        string Name { get; set; }

        string Department { get; set; } 

        string Designation { get; set; }

        void DisplayDetails ();
    }
}
