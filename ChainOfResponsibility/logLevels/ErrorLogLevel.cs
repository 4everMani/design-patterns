using System;
namespace ChainOfResponsibility
{
	public class ErrorLogLevel : AbstractLogLevel
	{
		public ErrorLogLevel(AbstractLogLevel abstractLogLevel)
            :base(abstractLogLevel)
		{
		}

        public override void Execute(Log log)
        {
            if(log.LogLevel == LogLevelEnum.Error)
            {
                Console.WriteLine("Log level=> {0} && Log message => {1}", log.LogLevel, log.Message);
                return;
            }
            else if(nextLogLevel is not null)
            {
                nextLogLevel.Execute(log);
            }
            
        }
    }
}

