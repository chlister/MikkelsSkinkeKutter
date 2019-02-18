namespace MikkelsSkinkeKutter.SnakeCharmer
{
    public class Order
    {
        public MenuItem MenuItem { get; private set; }
        public int CustomerId { get; private set; }

        public Order(MenuItem item, int customerId)
        {
            MenuItem = item;
            CustomerId = customerId;
        }
    }
}
