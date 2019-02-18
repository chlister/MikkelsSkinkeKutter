using MikkelsSkinkeKutter.SnakeCharmer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikkelsSkinkeKutter.Cust
{
public    class CustomerLine
    {
        static List<Customer> Customers = new List<Customer>();

        public CustomerLine()
        {
            Live();
        }

        private void Live()
        {
            // Task will keep this class alive
        }

        private void SpawnCustomer()
        {
            // Simulate new customers arriving
            Customers.Add(CustomerFatory.GenCustomer());
        } 

        public void GetOrder(Order Order)
        {
            // Find the customer matching the id - and give order
        }
    }
}
