using AbstractFactory.Interfaces;
using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class TraditionalFurnitureFactory : IFurnitureFactory
    {
        public IChair GetChair()
        {
            return new TraditionalChair();
        }

        public ISofa GetSofa()
        {
            return new TraditionalSofa();
        }

        public ITable GetTable()
        {
            return new TraditionalTable();
        }
    }
}
