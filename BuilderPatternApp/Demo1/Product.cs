using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class Product
    {
        private LinkedList<String> parts;

        public Product()
        {
            parts = new LinkedList<String>();
        }

        public void AddParts(string part)
        {
            parts.AddLast(part);
        }

        public void ShowParts()
        {
            foreach(string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
