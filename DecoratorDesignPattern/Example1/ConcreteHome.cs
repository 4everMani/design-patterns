using System;
namespace DecoratorDesignPattern.Example1
{
	public class ConcreteHome : AbstractHome
	{
		public ConcreteHome()
		{
            AdditionalCost = 0;
		}

        public override void MakeHome()
        {
            Console.WriteLine("Original house constructed. Price for this $10000");
        }
    }
}

