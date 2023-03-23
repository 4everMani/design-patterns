using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.builders
{
    public class MotorcycleBuilder2 : IBuilder2
    {
        private Product product;

        public MotorcycleBuilder2()
        {
            product = new Product();
        }

        public IBuilder2 AddEngine()
        {
            this.product.AddParts("Engine is Added to Motorcycle");
            return this;
        }

        public IBuilder2 AddHeadlights()
        {
            this.product.AddParts("Headlights are Added to Motorcycle");
            return this;
        }

        public IBuilder2 AddSeats()
        {
            this.product.AddParts("Added 2 Seats");
            return this;
        }

        public IBuilder2 BuildBody()
        {
            this.product.AddParts("Body is madeup of Alloy");
            return this;
        }

        public IBuilder2 InsertWheels()
        {
            this.product.AddParts("2 wheels added to Motorcycle");
            return this;
        }

        public IBuilder2 StartManufacturing()
        {
            this.product.AddParts("Manufacturing of motorcycle is started");
            return this;
        }

        public Product GetProduct()
        {
            return product;
        }
    }
}
