using System;
namespace ChainOfResponsibility
{
	public class WarningLogLevel : AbstractLogLevel
	{
		public WarningLogLevel(AbstractLogLevel abstractLogLevel)
            :base(abstractLogLevel)
		{
		}

        public override void Execute(Log log)
        {
            if (log.LogLevel == LogLevelEnum.Warning)
            {
                Console.WriteLine("Log level=> {0} && Log message => {1}", log.LogLevel, log.Message);
                return;
            }
            else if (nextLogLevel is not null)
            {
                nextLogLevel.Execute(log);
            }
        }
    }
}

