using System;

namespace Database
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string connectString = "www.sql.com";
            string instruction = "GetInfo";

            var sqlConnection = new SqlConnection(connectString);

            var databaseCommand = new DatabaseCommand(instruction, sqlConnection);

            databaseCommand.Execute();
        }
    }
}