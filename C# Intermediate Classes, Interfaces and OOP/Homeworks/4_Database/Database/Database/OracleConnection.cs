using System;

namespace Database
{
    public class OracleConnection : DatabaseConnection
    {
        public OracleConnection(string connectionString) 
            : base(connectionString)
        {

        }

        public override void Connect()
        {
            Console.WriteLine("Oracle is connected.");
        }

        public override void Disconnect()
        {
            Console.WriteLine("Oracle is disconnected.");
        }
    }
}
