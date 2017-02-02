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
            Console.WriteLine("\nSelect one of the following options, or any other number to quit: ");
            Console.WriteLine("1) Manage Account\n2) Select Portfolio");
            Console.WriteLine("3) Create Portfolio\n4) Delete Portfolio");
            int toReturn = Convert.ToInt32(Console.ReadLine());
            return toReturn;
        }

        /// <summary>
        /// Displays menu when user selects "Manage Account" from Main Menu.
        /// </summary>
        /// <returns>Returns users menu choice</returns>
        public static int AccountMenu()
        {
            Console.WriteLine("\nSelect one of the following options: ");
            Console.WriteLine("1) View Balance\n2) Deposit");
            Console.WriteLine("3) Withdraw\n4) Back to Main Menu");
            int toReturn = Convert.ToInt32(Console.ReadLine());
            return toReturn;
        }

        /// <summary>
        /// Shows balance menu when user selects "View Balance" from Account Menu
        /// </summary>
        /// <returns></returns>
        public static int BalanceMenu()
        {
            Console.WriteLine("\nSelect how you would like to view your balance: ");
            Console.WriteLine("1) Cash Positions\n2) Position Balance");
            Console.WriteLine("3) Gain/Loss Report\n4) Back to Main Menu");
            int toReturn = Convert.ToInt32(Console.ReadLine());
            return toReturn;
        }

        public static int PortfolioMenu()
        {
            Console.WriteLine("\nWhat would you like to do with this portfolio? ");
            Console.WriteLine("1) View Portfolio Balance\n2) Buy Stock");
            int toReturn = Convert.ToInt32(Console.ReadLine());
            return toReturn;
        }


    }//end class
}//end namespace
