using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod;

public class AirShipment : IShipment
{
    public decimal calculateTotalCharges()
    {
        return 1000;
    }

    public DateTime TotalTimeTakes()
    {
        return DateTime.UtcNow;
    }
}
