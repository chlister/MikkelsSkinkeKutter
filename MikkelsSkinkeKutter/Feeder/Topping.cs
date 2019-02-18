using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikkelsSkinkeKutter.Feeder
{
    public abstract class Topping
    {
        public int Servings { get; internal set; }

        public Topping()
        {
            Servings = 30;
        }

        /// <summary>
        /// Refills the topping container
        /// Servings is always 30
        /// </summary>
        public void Refill()
        {
            if (Servings == 0)
                Servings += 30;
        }
    }
}
