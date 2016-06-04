using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksConsole
{
    public static class ConsoleHelperFunctions
    {
        public static int GetNumberFromUser()
        {
            int number = 0;
            bool isValid = false;

            while ( isValid == false )
            {
                Console.Write( "Please enter a number: " );
                string input = Console.ReadLine();

                if ( int.TryParse( input, out number ) )
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine( "That number was invalid, please try again." );
                }
            }

            return number;
        }
    }
}
