using System;
using Castle.Facilities.Logging;
using Castle.Windsor;
using NLog;
using ILogger = Castle.Core.Logging.ILogger;

namespace NLogEvaluation
{
    class Program
    {
        private static ILogger logger; 
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.AddFacility<LoggingFacility>(f => f.UseNLog());
            logger = container.Resolve<ILogger>();

            //var eventInfo = new LogEventInfo();
            //eventInfo.Properties["Foo"] = Guid.NewGuid();
            //eventInfo.Message = "Foo Message";
            //eventInfo.Level = LogLevel.Debug;
            //logger.Log(eventInfo);

            MappedDiagnosticsLogicalContext.Set("messageId", Guid.NewGuid());
            MappedDiagnosticsLogicalContext.Set("requestId", Guid.NewGuid());
            MappedDiagnosticsLogicalContext.Set("commandName", "The Command Name");

            logger.Debug("debug message");
            logger.Info("info message");
            logger.Warn("warn message");

        }
    }
}
