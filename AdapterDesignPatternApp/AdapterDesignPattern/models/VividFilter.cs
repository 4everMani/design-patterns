using AdapterDesignPattern.interfaces;

namespace AdapterDesignPattern.models
{
    public class VividFilter : IFilter
    {
        public void ApplyFilter()
        {
            Console.WriteLine("Vivid filter is applied");
        }
    }
}
