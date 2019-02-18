using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikkelsSkinkeKutter.Feeder
{
    public class RoastedSausage : Sausage
    {
        public RoastedSausage()
        {
            CookingTime = 12;
            Duration = 6*60; // 6 hours
        }
    }
}
