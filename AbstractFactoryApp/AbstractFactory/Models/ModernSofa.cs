using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class ModernSofa : ISofa
    {
        public decimal TotalCost()
        {
            return 30000;
        }
    }
}
