using System;
namespace DecoratorDesignPattern.Example1
{
	public abstract class AbstractHome
	{
		public double AdditionalCost { get; set; }

		public abstract void MakeHome();
	}
}

