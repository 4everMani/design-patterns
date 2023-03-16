using AbstractFactory.Interfaces;
using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class ClassicFurnitureFactory : IFurnitureFactory
    {
        public IChair GetChair()
        {
            return new ClassicChair();
        }

        public ISofa GetSofa()
        {
            return new ClassicSofa();   
        }

        public ITable GetTable()
        {
            return new ClassicTable();
        }
    }
}
