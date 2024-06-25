namespace SOLID.Example.DIP.LoggerSystem
{
    /// <summary>
    ///  Initially, we might have a logging mechanism that writes messages to a console.
    ///  However, in the future, we may want to switch to logging messages in a file or sending them over the network.
    /// </summary>
    public class ConsoleLogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class NotificationService
    {
        private ConsoleLogger _logger = new ConsoleLogger();
        public void Notify(string message)
        {
            // ... some notification logic ...
            _logger.LogMessage(message);
        }
    }

    /// Problem issue
    /// The problem here is that NotificationService is directly dependent on ConsoleLogger. 
    /// What if we want to change our logging mechanism?
}
