using MikkelsSkinkeKutter.Feeder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikkelsSkinkeKutter.SnakeCharmer
{
    public class FoodInventory
    {
        List<Topping> Toppings = new List<Topping>();
        List<FoodItem> Items = new List<FoodItem>();

        public FoodInventory() { }

        /// <summary>
        /// Heats an foodItem and adds it to the inventory
        /// </summary>
        /// <param name="type"></param>
        internal void HeatFeed(FeedItem type)
        {

        }

        /// <summary>
        /// Refills and empty topping
        /// </summary>
        /// <param name="topping"></param>
        internal void RefillTopping(Topping topping)
        {
            if (topping.Servings == 0)
                topping.Refill();
        }
    }
}
