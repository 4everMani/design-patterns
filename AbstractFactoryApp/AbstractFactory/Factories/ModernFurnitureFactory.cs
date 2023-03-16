using AbstractFactory.Interfaces;
using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair GetChair()
        {
            return new ModernChair();
        }

        public ISofa GetSofa()
        {
            return new ModernSofa();
        }

        public ITable GetTable()
        {
            return new ModernTable();
        }
    }
}
