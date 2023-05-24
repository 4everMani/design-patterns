using System;
namespace DecoratorDesignPattern.Example2
{
	public abstract class AbstractPizza
	{
		protected double Cost { get; set; }

		public abstract double TotalCost();
	}
}

