using System;
namespace ChainOfResponsibility
{
	public abstract class AbstractLogLevel
	{
		protected AbstractLogLevel? nextLogLevel;

        public AbstractLogLevel(AbstractLogLevel? logLevel)
		{
			nextLogLevel = logLevel;

        }

		public abstract void Execute(Log log);
	}
}

