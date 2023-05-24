using System;
namespace DecoratorDesignPattern.Example2
{
	public class BasePizza : AbstractPizza
	{
		public BasePizza(double pizzaCost)
		{
			Cost = pizzaCost;
		}

        public override double TotalCost()
        {
            return Cost;
        }
    }
}

