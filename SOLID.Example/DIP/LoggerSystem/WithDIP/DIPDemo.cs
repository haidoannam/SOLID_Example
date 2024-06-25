using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Example.DIP.LoggerSystem.WithDIP
{
    /// <summary>
    /// By applying the Dependency Inversion Principle (DIP), we have decoupled the NotificationService from the concrete implementation of the logger. 
    /// This makes the system more flexible and open for extension.
    /// </summary>
    public interface ILogger
    {
        void LogMessage(string message);
    }

    //Concrete Loggers
    public class ConsoleLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class FileLogger : ILogger
    {
        private string _filePath;
        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }
        public void LogMessage(string message)
        {
            // Just a simple example. In a real-world scenario, proper exception handling and file IO management is needed.
            File.AppendAllText(_filePath, message);
        }
    }

    //Now, our NotificationService should depend on the abstraction
    public class NotificationService
    {
        private ILogger _logger;
        public NotificationService(ILogger logger)
        {
            _logger = logger;
        }
        public void Notify(string message)
        {
            // ... some notification logic ...
            _logger.LogMessage(message);
        }
    }
}
