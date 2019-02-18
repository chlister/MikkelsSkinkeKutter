using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikkelsSkinkeKutter.Cust;
using MikkelsSkinkeKutter.Feeder;

namespace MikkelsSkinkeKutter.SnakeCharmer
{
   public class SnakeCharmerMikkel
    {
        public const int MAXORDERS = 4; // Defines how many orders we take at a time
        public static List<Customer> ActiveOrders = new List<Customer>();


        public SnakeCharmerMikkel()
        {
            Live(); // Thought about making him a singleton for there is only one Mikkel - Right?
        }
        private void Live()
        {
            // Task will keep this class alive 
        }

        /// <summary>
        /// Handles orders from the ActiveOrders line
        /// </summary>
        /// <param name="order"></param>
        private void HandleOrder(Order order)
        {
            // As a start take the first customer
            ActiveOrders[0].Order
        }

        /// <summary>
        /// Gives the Order to the matching Customer in the line
        /// </summary>
        /// <param name="order"></param>
        private void GiveOrder(Order order)
        {

        }

        /// <summary>
        /// Prepares a item for a order and adds it to the inventory
        /// </summary>
        /// <param name="item"></param>
        private void Prepareitem(FeedItem item)
        {

        }

        /// <summary>
        /// Takes the next customer from the Queue in the Cust.CustomerLine and adds it to the ActiveOrders
        /// </summary>
        private void NextCustomer()
        {

        }
    }
}
