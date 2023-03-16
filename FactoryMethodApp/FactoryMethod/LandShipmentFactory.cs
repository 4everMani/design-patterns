using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class LandShipmentFactory : ShipmentFactory
    {
        protected override IShipment CreateShipment()
        {
            return new LandShipment();
        }
    }
}
