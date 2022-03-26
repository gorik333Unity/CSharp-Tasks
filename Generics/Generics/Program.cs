using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        private static void Main(string[] args)
        {
            WhereTStruct();
        }

        private static void WhereTStruct()
        {
            var number = new Nullable<int>(5);

            Console.WriteLine("Has value: " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());

            Console.ReadLine();
        }
    }
}
