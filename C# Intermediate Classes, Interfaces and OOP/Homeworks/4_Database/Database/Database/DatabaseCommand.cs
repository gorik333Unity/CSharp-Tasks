using System;

namespace Database
{
    public class DatabaseCommand
    {
        private readonly DatabaseConnection _databaseConnection;
        private readonly string _instruction;

        public DatabaseCommand(string instruction, DatabaseConnection databaseConnection)
        {
            if (databaseConnection == null)
                throw new ArgumentNullException("DatabaseConection cannot be null");

            _databaseConnection = databaseConnection;

            if (string.IsNullOrEmpty(instruction))
                throw new ArgumentNullException("The instruction is null or empty");

            _instruction = instruction;
        }

        public void Execute()
        {
            _databaseConnection.Connect();

            Console.WriteLine("Instruction: {0}", _instruction);

            _databaseConnection.Disconnect();
        }
    }
}
