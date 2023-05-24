using System;
namespace DecoratorDesignPattern.Example2
{
	public abstract class AbstractToppings : AbstractPizza
	{
		protected AbstractPizza pizza;
		public AbstractToppings(AbstractPizza abstractPizza)
		{
			pizza = abstractPizza;
		}

	}
}

