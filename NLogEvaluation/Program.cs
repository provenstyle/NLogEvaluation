using System;
using NLog;

namespace NLogEvaluation
{
    class Program
    {
        private static ILogger logger; 
        static void Main(string[] args)
        {
            logger = LogManager.GetCurrentClassLogger();

            //var eventInfo = new LogEventInfo();
            //eventInfo.Properties["Foo"] = Guid.NewGuid();
            //eventInfo.Message = "Foo Message";
            //eventInfo.Level = LogLevel.Debug;
            //logger.Log(eventInfo);

            MappedDiagnosticsLogicalContext.Set("messageId", Guid.NewGuid());
            MappedDiagnosticsLogicalContext.Set("requestId", Guid.NewGuid());
            MappedDiagnosticsLogicalContext.Set("commandName", "The Command Name");

            logger.Trace("trace message");
            logger.Debug("debug message");
            logger.Info("info message");
        }
    }
}
