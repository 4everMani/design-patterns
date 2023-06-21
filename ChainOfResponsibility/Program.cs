using ChainOfResponsibility;
using ChainOfResponsibility.logLevels;

Console.WriteLine("Chain of Responsibility design pattern");
Console.WriteLine();
Console.WriteLine();

var errorLog = new Log { LogLevel = LogLevelEnum.Error, Message = "This is an error message" };
var warningLog = new Log { LogLevel = LogLevelEnum.Warning, Message = "This is a warning message" };
var infoLog = new Log { LogLevel = LogLevelEnum.Info, Message = "This is an info message" };

AbstractLogLevel logLevel = new ErrorLogLevel(new WarningLogLevel(new InfoLogLevel()));
logLevel.Execute(errorLog);
logLevel.Execute(warningLog);
logLevel.Execute(infoLog);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Changing the order");
Console.WriteLine();
Console.WriteLine();

logLevel.Execute(infoLog);
logLevel.Execute(errorLog);
logLevel.Execute(warningLog);
