using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.RobotParts
{
    public class RobotColor
    {
        string color;
        public RobotColor(string color)
        {
            this.color = color;
        }
        public void SetColor()
        {
            if (color == "steel")
            {
                Console.WriteLine($"The default color {color} is set for the robot.");
            }
            else
            {
                Console.WriteLine($"Painting the robot with your favourite { color} color.");
            }
        }
        public void RemoveColor()
        {
            Console.WriteLine("Attempting to remove the colors from robot.");
        }
    }
}
