using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikkelsSkinkeKutter.Cust;

namespace MikkelsSkinkeKutter.SnakeCharmer
{
   public class SnakeCharmerMikkel
    {
        public const int MAXORDERS = 4; // Defines how many orders we take at a time
        public List<Customer> ActiveOrders = new List<Customer>();


        public SnakeCharmerMikkel()
        {
            Live(); // Thought about making him a singleton for there is only one Mikkel - Right?
        }
        private void Live()
        {
            // Task will keep this class alive 
        }

        private void 
    }
}
