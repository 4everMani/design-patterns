using AdapterDesignPattern._3rdPartyFilters;
using AdapterDesignPattern.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.adapetrs
{
    public class FilterAdapter : IFilter
    {
        private SnowWhite _snowWhite;

        public FilterAdapter(SnowWhite snowWhite)
        {
            _snowWhite = snowWhite;
        }
        public void ApplyFilter()
        {
            _snowWhite.Init();
            _snowWhite.ApplyFilter();
        }
    }
}
