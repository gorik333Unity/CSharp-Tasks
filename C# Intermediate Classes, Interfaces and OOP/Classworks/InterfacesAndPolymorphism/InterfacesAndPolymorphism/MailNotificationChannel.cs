namespace InterfacesAndPolymorphism
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Email notification");
        }
    }
}
