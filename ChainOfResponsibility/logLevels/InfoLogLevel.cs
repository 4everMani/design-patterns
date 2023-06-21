using System;
namespace ChainOfResponsibility.logLevels
{
	public class InfoLogLevel : AbstractLogLevel
	{
		public InfoLogLevel(): base(null)
		{
		}

        public override void Execute(Log log)
        {
            if (log.LogLevel == LogLevelEnum.Info)
            {
                Console.WriteLine("Log level=> {0} && Log message => {1}", log.LogLevel, log.Message);
                return;
            }
            else if (nextLogLevel is not null)
            {
                nextLogLevel.Execute(log);
            }
            Console.WriteLine("No handlers to handle this log level");
        }
    }
}

