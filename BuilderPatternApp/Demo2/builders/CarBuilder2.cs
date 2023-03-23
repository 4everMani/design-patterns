using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.builders
{
    public class CarBuilder2 : IBuilder2
    {
        private Product product;

        public CarBuilder2()
        {
            this.product = new Product();   
        }
        public IBuilder2 AddEngine()
        {
            this.product.AddParts("Engine is Added");
            return this;
        }

        public IBuilder2 AddHeadlights()
        {
            this.product.AddParts("Headlights are Added");
            return this;
        }

        public IBuilder2 AddSeats()
        {
            this.product.AddParts("Added 5 Seats");
            return this;
        }

        public IBuilder2 BuildBody()
        {
            this.product.AddParts("Body is madeup of Metal");
            return this;
        }

        public IBuilder2 InsertWheels()
        {
            this.product.AddParts("4 wheels added to Car");
            return this;
        }

        public IBuilder2 StartManufacturing()
        {
            this.product.AddParts("Manufacturing of car is started");
            return this;
        }

        public Product GetProduct()
        {
            return product;
        }
    }
}
