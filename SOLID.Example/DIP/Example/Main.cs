using DependencyInversionPrinciple;
using DependencyInversionPrinciple.AfterDI.Notifications;
using DependencyInversionPrinciple.BeforeDI;


namespace SOLID.Example.DIP.Example
{
    public class Main
    {
        public void ApplyWithoutDI()
        {
            NotificationController notificationController = new NotificationController();
            var notificationItems = CreateDemoData();

            foreach (var item in notificationItems)
            {
                switch (item.NotificationType)
                {
                    case NotificationType.EMAIL:
                        notificationController.SendEmailNotification(item);
                        break;
                    case NotificationType.PUSH:
                        notificationController.SendPushNotification(item);
                        break;
                    case NotificationType.SMS:
                        notificationController.SendSmsNotification(item);
                        break;
                    default:
                        throw new NotSupportedException();
                }
            }
        }

        //public void ApplyDI()
        //{
        //    DependencyInversionPrinciple.BeforeDI.NotificationController notificationController =
        //       new NotificationController(NotificationFactory.CreateMessengers());
        //    var notificationItems = CreateDemoData();
        //    notificationController.AddToQueue(notificationItems);
        //    notificationController.Send();
        //}

        private static List<NotificationItem> CreateDemoData()
        {
            return new List<NotificationItem>
            {
                new NotificationItem
                {
                    Id = Guid.NewGuid(),
                    Title = "This is title notification for SMS",
                    Content = "I love you",
                    CreatedDate = DateTime.Now.AddDays(-1),
                    SentDate = DateTime.Now,
                    NotificationType = NotificationType.SMS
                },
                new NotificationItem
                {
                    Id = Guid.NewGuid(),
                    Title = "This is title notification for Email",
                    Content = "I love you",
                    CreatedDate = DateTime.Now.AddDays(-1),
                    SentDate = DateTime.Now,
                    NotificationType = NotificationType.EMAIL
                },
                new NotificationItem
                {
                    Id = Guid.NewGuid(),
                    Title = "This is title notification for Push",
                    Content = "I love you",
                    CreatedDate = DateTime.Now.AddDays(-1),
                    SentDate = DateTime.Now,
                    NotificationType = NotificationType.PUSH
                }
            };
        }
    }
}
