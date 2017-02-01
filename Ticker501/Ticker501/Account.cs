/* Account.cs
 * Author: Elizabeth Hall
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticker501
{
    class Account
    {
        //balance in dollars
        public double balance;

        public const double TRANSFER_FEE = 4.99;

        /// <summary>
        /// Constructs empty account with 0 dollars
        /// </summary>
        public Account()
        {
            balance = 0;
        }//end constructor

        /// <summary>
        /// Deposits amount given into account, minus the fee
        /// </summary>
        /// <param name="amt">Amount passed in to deposit</param>
        public void Deposit(double amt)
        {
            balance += amt;
            balance -= TRANSFER_FEE;
            Console.WriteLine("Deposit successful. New balance: " + balance);
        }//end Deposit

        /// <summary>
        /// Withdraws amount given from account, and charges fee
        /// </summary>
        /// <param name="amt">Amount given to withdraw</param>
        public void Withdraw(double amt)
        {
            if(amt + 4.99 > balance)
            {
                Console.WriteLine("You don't have enough in your account! Current balance: " + balance);
            }
            else
            {
                balance -= amt;
                balance -= TRANSFER_FEE;
                Console.WriteLine("Withdrawl successful. New balance: " + balance);
            }

        }//end Withdraw

    }//end class
}//end namespace
