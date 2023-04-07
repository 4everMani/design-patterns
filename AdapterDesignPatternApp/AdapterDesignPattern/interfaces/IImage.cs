using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.interfaces
{
    public interface IImage
    {
        void UseFilter(IFilter filter);
    }
}
