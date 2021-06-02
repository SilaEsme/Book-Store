namespace OnlineBookStore
{
    public enum typeMagazine { Culture, Technology, Science, Geography, Caricature, Kids, Society, Art, Entertainment, Other }

    public class Magazine : Product
    {
        private string productName, productPrice;
        private string issue;
        private typeMagazine TypeMagazine;

        public typeMagazine _TypeMagazine
        {
            get => TypeMagazine;
            set => TypeMagazine = value;
        }

        public Magazine()
        {
        }

        public override string ProductName
        {
            get => productName;
            set => productName = value;
        }

        public string Issue
        {
            get => issue;
            set => issue = value;
        }

        public override string ProductPrice
        {
            get => productPrice;
            set => productPrice = value;
        }
    }
}