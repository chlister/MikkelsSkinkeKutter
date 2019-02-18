using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikkelsSkinkeKutter.Cust
{
  public  class CustomerFatory
    {
        public static Customer GenCustomer()
        {
            return new Customer();
        }
    }
}
