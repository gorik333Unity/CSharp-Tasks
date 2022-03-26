﻿namespace InterfacesAndPolymorphism
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("SMS notification");
        }
    }
}
