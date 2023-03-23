using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.builders
{
    public class CarBuilder : IBuilder
    {
        private Product product;

        public CarBuilder()
        {
            this.product = new Product();   
        }
        public void AddEngine()
        {
            this.product.AddParts("Engine is Added");
        }

        public void AddHeadlights()
        {
            this.product.AddParts("Headlights are Added");
        }

        public void AddSeats()
        {
            this.product.AddParts("Added 5 Seats"); ;
        }

        public void BuildBody()
        {
            this.product.AddParts("Body is madeup of Metal"); ;
        }

        public void InsertWheels()
        {
            this.product.AddParts("4 wheels added to Car");
        }

        public void StartManufacturing()
        {
            this.product.AddParts("Manufacturing of car is started");
        }

        public Product GetProduct()
        {
            return product;
        }
    }
}
