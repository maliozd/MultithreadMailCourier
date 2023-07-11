namespace MultithreadMailCourier
{
    public class LogManager
    {
        private static LogManager logManager;
        public static LogManager Instance => logManager ??= new LogManager();
        public event EventHandler<string> OnLogAdded;
        public void Log(string logMessage)
        {
            OnLogAdded?.Invoke(this, logMessage);
        }
    }
}
