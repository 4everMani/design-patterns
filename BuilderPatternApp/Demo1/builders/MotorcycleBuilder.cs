using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.builders
{
    public class MotorcycleBuilder : IBuilder
    {
        private Product product;

        public MotorcycleBuilder()
        {
            product = new Product();
        }

        public void AddEngine()
        {
            this.product.AddParts("Engine is Added to Motorcycle");
        }

        public void AddHeadlights()
        {
            this.product.AddParts("Headlights are Added to Motorcycle");
        }

        public void AddSeats()
        {
            this.product.AddParts("Added 2 Seats"); ;
        }

        public void BuildBody()
        {
            this.product.AddParts("Body is madeup of Alloy"); ;
        }

        public void InsertWheels()
        {
            this.product.AddParts("2 wheels added to Motorcycle");
        }

        public void StartManufacturing()
        {
            this.product.AddParts("Manufacturing of motorcycle is started");
        }

        public Product GetProduct()
        {
            return product;
        }
    }
}
