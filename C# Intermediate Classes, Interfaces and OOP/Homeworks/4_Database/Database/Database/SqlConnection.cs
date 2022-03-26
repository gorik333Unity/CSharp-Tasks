using System;

namespace Database
{
    public class SqlConnection : DatabaseConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {

        }

        public override void Connect()
        {
            Console.WriteLine("SQL is connected.");
        }

        public override void Disconnect()
        {
            Console.WriteLine("SQL is disconnected.");
        }
    }
}
