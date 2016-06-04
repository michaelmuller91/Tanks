using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Common;

namespace TanksConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank tank1 = new Tank( "Tank 1" );

            Console.WriteLine( "Please enter the number of tanks you want to create: " );
            int numberOfTanks = ConsoleHelperFunctions.GetNumberFromUser();

            Console.ReadKey();
        }
    }
}
