using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod;

public class LandShipment : IShipment
{
    public decimal calculateTotalCharges()
    {
        return 5000;
    }

    public DateTime TotalTimeTakes()
    {
        return DateTime.Now;
    }
}
