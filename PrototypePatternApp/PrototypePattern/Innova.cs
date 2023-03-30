using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Innova : BasicCar
    {
        public Innova()
        {
            CarName = "Innova";
            Price = 2500000;
        }

        public override BasicCar GetClone()
        {
            return MemberwiseClone() as Innova;
        }
    }
}
