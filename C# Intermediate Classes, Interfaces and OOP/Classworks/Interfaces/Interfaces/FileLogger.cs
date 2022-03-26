using System;
using System.IO;

namespace Interfaces
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            if (!string.IsNullOrEmpty(path))
                _path = path;
        }

        public void LogInfo(string message)
        {
            Log(message, messageType: "INFO");
        }

        public void LogError(string message)
        {
            Log(message, messageType: "ERROR");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, append: true))
            {
                streamWriter.WriteLine(messageType + ": " + message + "Date: " + DateTime.Now);
                streamWriter.Dispose();
            }
        }
    }
}
