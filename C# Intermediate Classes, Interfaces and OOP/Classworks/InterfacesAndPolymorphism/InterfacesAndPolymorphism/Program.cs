using System;

namespace InterfacesAndPolymorphism
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var videoRecorder = new VideoRecorder();

            videoRecorder.RegisterNotificationChannel(new MailNotificationChannel());
            videoRecorder.RegisterNotificationChannel(new SmsNotificationChannel());

            videoRecorder.Encode(new Video());

            Console.ReadLine();
        }
    }
}
