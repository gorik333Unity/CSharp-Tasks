using System;
using System.IO;

namespace Interfaces
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger(Directory.GetCurrentDirectory()));
            dbMigrator.Migrate();

            // or

            var dbMigratorFile = new DbMigrator(new ConsoleLogger());
            dbMigratorFile.Migrate();

            Console.Read();
        }
    }
}
