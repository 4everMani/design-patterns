using System;
namespace DecoratorDesignPattern.Example2
{
	public class ChilliTopping  : AbstractToppings
    {
        public ChilliTopping(AbstractPizza pizza) : base(pizza)
        {
        }

        public override double TotalCost()
        {
            return base.pizza.TotalCost() + 70;
        }
    }
}

