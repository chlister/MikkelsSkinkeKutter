using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikkelsSkinkeKutter.Feeder
{
   public abstract class FoodItem
    {
        public double CookingTime { get; internal set; }
        public double Duration { get; internal set; }
        public DateTime CookedTime { get; private set; }
        public bool Usable { get; private set; }


        public FoodItem()
        {
            CookedTime = DateTime.Now;
            Usable = true;
        }

        /// <summary>
        /// Checks if the item has gone bad
        /// </summary>
        internal void Checkusability()
        {
            Usable = CookedTime.AddMinutes(Duration) < DateTime.Now ? false : true;
        }
    }
}
