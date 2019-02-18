using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikkelsSkinkeKutter.Feeder
{
   public class CookedSausage : Sausage
    {
        public CookedSausage()
        {
            CookingTime = 10;
            Duration = 6*60; //6 hours
        }
    }
}
