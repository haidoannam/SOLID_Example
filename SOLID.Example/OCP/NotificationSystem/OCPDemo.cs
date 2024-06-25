
namespace SOLID.Example.OCP.NotificationSystem
{
    public enum NotificationChannel
    {
        Email,
        SMS
    }
    public class NotificationSender
    {
        public void SendNotification(NotificationChannel channel, string message)
        {
            switch (channel)
            {
                case NotificationChannel.Email:
                    Console.WriteLine($"Sending Email: {message}");
                    break;
                case NotificationChannel.SMS:
                    Console.WriteLine($"Sending SMS: {message}");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
