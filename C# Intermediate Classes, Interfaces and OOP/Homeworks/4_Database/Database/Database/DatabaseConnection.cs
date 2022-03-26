using System;

namespace Database
{
    public abstract class DatabaseConnection
    {
        private readonly string _connectionString;
        private readonly TimeSpan _timeout;

        protected DatabaseConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException("The connection string cannot be null, whitespace or empty");

            _connectionString = connectionString;
        }

        public abstract void Connect();

        public abstract void Disconnect();
    }
}
