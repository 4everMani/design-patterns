using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Tesla : BasicCar
    {
        public Tesla()
        {
            CarName = "Tesla";
            Price = 3500000;
        }

        public override BasicCar GetClone()
        {
            return MemberwiseClone() as Tesla;
        }
    }
}
