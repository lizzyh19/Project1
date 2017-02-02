/* Program.cs
 * Author: Elizabeth Hall
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ticker501
{
    class Program
    {
        /// <summary>
        /// Controls whole program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //creates user's account
            Account account = new Account();
            //stores portfolios and information, using name as key
            Dictionary<string, Portfolio> portfolios = new Dictionary<string, Portfolio>();
            //stores all stocks read in from file, ticker as key
            Dictionary<string, Stock> stocks = new Dictionary<string, Stock>();

            //all file IO to start
            Console.WriteLine("Enter name of file to use: ");
            string fileName = Console.ReadLine();
            string line;
            string amount;
            double amtPass;
            string[] array = new string[3];

            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    //reads in and creates stock object
                    line = sr.ReadLine();
                    array = line.Split('-');
                    amount = array[2].Substring(1);
                    amtPass = Convert.ToDouble(amount);
                    Stock toAdd = new Stock(array[0], array[1], amtPass);

                    //adds to dictionary
                    stocks.Add(array[0], toAdd);
                }
            }

            int answer = 1;

            while(answer == 1 || answer == 2 || answer == 3 || answer == 4)
            {
                answer = Display.MainMenu();

                //manage account
                if (answer == 1)
                {
                    int accountAnswer = Display.AccountMenu();
                    //Balance
                    if (accountAnswer == 1)
                    {
                        int balanceAnswer = Display.BalanceMenu();
                        //Cash and positions
                        if (balanceAnswer == 1)
                        {
                            Console.WriteLine("Cash and positions selected");
                        }
                        //Position balance
                        else if(balanceAnswer == 2)
                        {
                            Console.WriteLine("Position balance selected");
                        }
                        //gains/loss report
                        else if (balanceAnswer == 3)
                        {
                            Console.WriteLine("Gains/loss report selected");
                        }
                        //main menu
                        else if (accountAnswer == 4)
                        {
                            continue;
                        }
                        //invalid input
                        else
                        {
                            Console.WriteLine("Error, returning to Main Menu");
                            continue;
                        }
                    }
                    //deposit
                    else if (accountAnswer == 2)
                    {
                        Console.Write("Enter amount to deposit: ");
                        double depositAmt = Convert.ToDouble(Console.ReadLine());
                        account.Deposit(depositAmt);
                    }
                    //withdraw
                    else if (accountAnswer == 3)
                    {
                        Console.Write("Enter amount to withdraw: ");
                        double withAmt = Convert.ToDouble(Console.ReadLine());
                        account.Withdraw(withAmt);
                    }
                    //back to main menu
                    else if (accountAnswer == 4)
                    {
                        continue;
                    }
                    //invalid input
                    else
                    {
                        Console.WriteLine("Error, returning to Main Menu");
                        continue;
                    }
                }//end manage account

                //select portfolio
                else if(answer == 2)
                {
                    //checks if there are portfolios
                    if(portfolios.Count == 0)
                    {
                        Console.WriteLine("You haven't made any portfolios!\n");
                    }
                    else
                    {
                        //displays all portfolios
                        foreach(string k in portfolios.Keys)
                        {
                            Portfolio v;
                            portfolios.TryGetValue(k, out v);
                            Console.WriteLine(v.ToString());
                        }

                        Console.WriteLine("Type the name of the portfolio to select from above list: ");
                        string selected = Console.ReadLine();
                        //if doesn't exist
                        if (!portfolios.ContainsKey(selected) )
                        {
                            Console.WriteLine("That portfolio doesn't exist, returning to Main Menu");
                            continue;
                        }
                        //found portfolio
                        else
                        {
                            Console.WriteLine("Successfully found portfolio");
                        }
                    }


                }//end select portfolio

                //create portfolio
                else if(answer == 3)
                {
                    if (portfolios.Count == 3)
                    {
                        Console.WriteLine("You already have 3 portfolios!\n");
                    }
                    else
                    {
                        Console.Write("Enter Portfolio Name: ");
                        string portName = Console.ReadLine();
                        portfolios.Add(portName, new Portfolio(portName));
                    }

                }//end create portfolio

                //delete portfolio
                else if(answer == 4)
                {
                    if (portfolios.Count == 0)
                    {
                        Console.WriteLine("You don't have any portfolios to delete!");
                    }
                    else
                    {
                        Console.Write("Which portfolio would you like to delete? ");
                        string toDelete = Console.ReadLine();
                        bool removed = portfolios.Remove(toDelete);

                        //verify it was removed
                        if (removed)
                        {
                            Console.WriteLine(toDelete + " portfolio successfully removed");
                        }
                        else
                        {
                            Console.WriteLine("That portfolio doesn't exist!");
                        }
                    }

                }//end delete portfolio

                //Exit
                else
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }//end overall while

            Console.WriteLine("Goodbye!");

        }//end Main



    }//end Class
}//End namespace
