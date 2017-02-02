/* Portfolio.cs
 * Author: Elizabeth Hall
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticker501
{
    class Portfolio
    {
        public string name;
        public double portBalance;
        public const double TRADE_FEE = 9.99;

        //holds all the stocks in the portfolio. Key = ticker, value = stock object
        Dictionary<string, Stock> dictionary = new Dictionary<string, Stock>();

        /// <summary>
        /// Constructs new portfolio and assigns name
        /// </summary>
        /// <param name="n">Given name of the portfolio</param>
        public Portfolio(string n)
        {
            name = n;
        }

        /// <summary>
        /// Functionality to purchase stock
        /// </summary>
        public void buyStock()
        {

        }

        public void EnterPortfolio()
        {
            int response = Display.PortfolioMenu();
            //portfolio balance
            if (response == 1)
            {
                int balanceResponse = Display.BalanceMenu();
            }
            //buy stock
            else
            {
                buyStock();
            }
        }

        /// <summary>
        /// Overrides ToString to just display the name of the stock
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return name;
        }



    }//end class
}//end namespace
