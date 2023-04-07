using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern._3rdPartyFilters
{
    public class SnowWhite
    {
        public void Init()
        {
            Console.WriteLine("Initializing SnowWhite Filter");
        }

        public void ApplyFilter()
        {
            Console.WriteLine("SnowWhite Filter is applied");
        }
    }
}
