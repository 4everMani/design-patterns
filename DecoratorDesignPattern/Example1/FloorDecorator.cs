using System;
namespace DecoratorDesignPattern.Example1
{
	public class FloorDecorator : AbstractDecorator
	{
		public FloorDecorator(AbstractHome abstractHome):base(abstractHome)
		{
			AdditionalCost = 2500;
		}

        public override void MakeHome()
        {
            base.MakeHome();
			AddFloor();
        }

		private void AddFloor()
		{
			Console.WriteLine($"Floor is added, Pay ${AdditionalCost} for this");
		}
    }
}

