using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod;

public abstract class ShipmentFactory
{
    public IShipment GetShipmentObject()
    {
        return CreateShipment();
    }

    protected abstract IShipment CreateShipment();
}
