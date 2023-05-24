using System;
namespace DecoratorDesignPattern.Example1
{
	public abstract class AbstractDecorator : AbstractHome
	{
		protected AbstractHome home;

		public AbstractDecorator(AbstractHome abstractHome)
		{
			home = abstractHome;
		}

        public override void MakeHome()
        {
			home.MakeHome();
        }
    }
}

