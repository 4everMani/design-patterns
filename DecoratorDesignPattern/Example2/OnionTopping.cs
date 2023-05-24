using System;
namespace DecoratorDesignPattern.Example2
{
	public class OnionTopping : AbstractToppings
	{
		public OnionTopping(AbstractPizza pizza): base(pizza)
		{
		}

        public override double TotalCost()
        {
            return base.pizza.TotalCost() + 50;
        }
    }
}

