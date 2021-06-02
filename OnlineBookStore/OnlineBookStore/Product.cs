namespace OnlineBookStore
{
    public abstract class Product
    {
        private string productName;
        private static int productId;
        private string productPrice;

        public Product()
        {
        }
        public virtual string ProductName
        {
            get => productName;
            set => productName = value;
        }
        public virtual string ProductPrice
        {
            get => productPrice;
            set => productName = value;
        }
        public void PrintProperties()
        {
        }
    }
}