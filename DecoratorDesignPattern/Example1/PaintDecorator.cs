using System;
namespace DecoratorDesignPattern.Example1
{
	public class PaintDecorator : AbstractDecorator
	{
		public PaintDecorator(AbstractHome abstractHome): base(abstractHome)
		{
			AdditionalCost = 12000;
		}

        public override void MakeHome()
        {
            //base.MakeHome();
			PaintHouse();
        }

        private void PaintHouse()
		{
			Console.WriteLine($"House is painted, Pay ${AdditionalCost} for it.");
		}
	}
}

