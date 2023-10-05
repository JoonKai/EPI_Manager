using NLog;

namespace HellsysLibrary.Helpers
{
    public class LogHelper
    {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();
        public void Debug(string message)
        {
            logger.Debug(message);
        }
        public void Info(string message)
        {
            logger.Info(message);
        }
        public void Warn(string message)
        {
            logger.Warn(message);
        }
        public void Error(string message)
        {
            logger.Error(message);
        }
    }
}
