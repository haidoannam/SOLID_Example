
namespace SOLID.Example.OCP.NotificationSystem.WithOCP
{
    public interface INotificationChannel
    {
        void Send(string message);
    }
    //Implement this interface for each channel
    public class EmailNotification : INotificationChannel
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
        }
    }
    public class SMSNotification : INotificationChannel
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
    //Modify the NotificationSender class to accept any INotificationChannel
    public class NotificationSender
    {
        private readonly INotificationChannel _channel;
        public NotificationSender(INotificationChannel channel)
        {
            _channel = channel;
        }
        public void SendNotification(string message)
        {
            _channel.Send(message);
        }
    }


    public class NotificationService
    {
        public void Notification()
        {
            var emailChannel = new EmailNotification();
            var sender = new NotificationSender(emailChannel);
            sender.SendNotification("Hello via Email!");
            var smsChannel = new SMSNotification();
            sender = new NotificationSender(smsChannel);
            sender.SendNotification("Hello via SMS!");
        }
    }
}
