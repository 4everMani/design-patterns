using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public abstract class BasicCar
    {
        public decimal Price { get; set; }

        public string CarName { get; set; }

        public abstract BasicCar GetClone();

        public static decimal AddTaxes()
        {
            var tax = new Random().Next(10000, 25000);
            return decimal.Parse(tax.ToString());
        }
    }
}
