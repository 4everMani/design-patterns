using AdapterDesignPattern.interfaces;

namespace AdapterDesignPattern.models
{
    public class Image : IImage
    {
        public void UseFilter(IFilter filter)
        {
            filter.ApplyFilter();
        }
    }
}
