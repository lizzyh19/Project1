/* Stock.cs
 * Author: Elizabeth Hall
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticker501
{
    class Stock
    {
        //value of stock in dollars
        public double value;
        //not relevant in main dictionary, given values for stocks in portfolios
        public int shares;
        public string ticker;
        public string name;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Stock()
        {

        }//end default constructor

        public Stock(string tickerIn, string nameIn, double amtIn)
        {
            ticker = tickerIn;
            name = nameIn;
            value = amtIn;
        }


    }//end class
}//end namespace
