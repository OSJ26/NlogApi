using Nlog.PL.Interface;
using NLog;

namespace Nlog.PL.Service
{
    public class SimpleLog : ILog
    {
        private static NLog.ILogger logger = LogManager.GetCurrentClassLogger();

        public SimpleLog() { }
        public void Log(string message)
        {

            logger.Info(message);
        }
    }
}
