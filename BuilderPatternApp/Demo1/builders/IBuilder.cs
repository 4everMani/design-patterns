using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.builders
{
    public interface IBuilder
    {
        void StartManufacturing();

        void AddEngine();

        void InsertWheels();

        void BuildBody();

        void AddHeadlights();

        void AddSeats();

    }
}
