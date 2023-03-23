using Demo1.builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class Director
    {
        private IBuilder builder;

        public void Construct(IBuilder builder)
        {
            this.builder = builder;
            builder.StartManufacturing();
            builder.AddEngine();
            builder.InsertWheels();
            builder.AddHeadlights();
            builder.BuildBody();
            builder.AddSeats();
        }
    }
}
