using System;
using System.Collections.Generic;

namespace InterfacesAndPolymorphism
{
    public class VideoRecorder
    {
        private readonly List<INotificationChannel> _notificationChannel;

        public VideoRecorder()
        {
            _notificationChannel = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // Video encoding logic

            foreach (var channel in _notificationChannel)
                channel.Send(new Message());
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannel.Add(channel);
        }
    }
}
