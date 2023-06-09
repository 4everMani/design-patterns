﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.RobotParts
{
    internal class RobotBody
    {
        string robotType;
        /*
        * To keep a count of number of robots.
        * This operation is optional for you.
        */
        static int count = 0;
        public RobotBody(string robotType)
        {
            this.robotType = robotType;
        }
        public void MakeRobotBody()
        {
            Console.WriteLine($"Constructing one {robotType} robot.");
            Console.WriteLine("Robot creation finished.");
            Console.WriteLine($"Total number of robot created at this moment ={ ++count}");
        }
        public void DestroyRobotBody()
        {
            if (count > 0)
            {
                --count;
                Console.WriteLine("Robot's destruction process is over.");
            }
            else
            {
                Console.WriteLine("All robots are destroyed.");
                Console.WriteLine("Color removal operation will continue.");
            }
        }
    }
}
