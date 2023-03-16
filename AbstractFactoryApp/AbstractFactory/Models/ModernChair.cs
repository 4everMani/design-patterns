using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class ModernChair : IChair
    {
        public decimal TotalCost()
        {
            return 4000;
        }
    }
}
