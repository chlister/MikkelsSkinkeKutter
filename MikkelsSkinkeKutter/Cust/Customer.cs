using MikkelsSkinkeKutter.SnakeCharmer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikkelsSkinkeKutter.Cust
{
    public class Customer
    {
        public static int Id { get; private set; }
        public Order Order { get; private set; }
        public int CustomerId { get; private set; }

        public Customer()
        {
            Id++;
            CustomerId = Id;
            GenOrder(CustomerId);
        }

        internal void GenOrder(int id)
        {
            // Hard coded right now
            Order = new Order(MenuItem.Hotdog, id);
        }
    }
}
