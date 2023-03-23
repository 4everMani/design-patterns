using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.builders
{
    public interface IBuilder2
    {
        IBuilder2 StartManufacturing();

        IBuilder2 AddEngine();

        IBuilder2 InsertWheels();

        IBuilder2 BuildBody();

        IBuilder2 AddHeadlights();

        IBuilder2 AddSeats();

        Product GetProduct();

    }
}
