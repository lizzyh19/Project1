using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticker501
{
    static class Display
    {
        /// <summary>
        /// Displays main menu to user
        /// </summary>
        /// <returns>User's answer as an int</returns>
        public static int MainMenu()
        {
            Console.WriteLine("\nSelect one of the following options, or any other key to quit: ");
            Console.WriteLine("1) Manage Account\n2) Select Portfolio");
            Console.WriteLine("3) Create Portfolio\n4) Delete Portfolio");
            int toReturn = Convert.ToInt32(Console.ReadLine());
            return toReturn;
        }

        public static int AccountMenu()
        {
            Console.WriteLine("\nSelect one of the following options: ");
            Console.WriteLine("1) View Balance\n2) Deposit");
            Console.WriteLine("3) Withdraw\n4) Back to Main Menu");
            int toReturn = Convert.ToInt32(Console.ReadLine());                      
            return toReturn;
        }

        public static int BalanceMenu()
        {

            Console.WriteLine("\nSelect how you would like to view your balance: ");
            Console.WriteLine("1) Cash Positions\n2) Position Balance");
            Console.WriteLine("3) Gain/Loss Report\n4) Back to Accoun Menu");
            int toReturn = Convert.ToInt32(Console.ReadLine());
            return toReturn;
        }

    }//end class
}//end namespace
