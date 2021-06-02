namespace OnlineBookStore
{
    public class ItemToPurchase
    {
        private Product product;
        private string quantity;

        public ItemToPurchase()
        {
        }

        public Product Product
        {
            get => product;
            set => product = value;
        }
        public string Quantity
        {
            get => quantity;
            set => quantity = value;
        }
    }
}