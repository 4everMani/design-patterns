using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class TraditionalTable : ITable
    {
        public decimal TotalCost()
        {
            return 3000;
        }
    }
}
