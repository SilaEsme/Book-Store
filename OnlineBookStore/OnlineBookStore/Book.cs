namespace OnlineBookStore
{
    public enum _type { Fiction, Classic, Story, TurkishClassic, Education, x }

    public class Book : Product
    {
        private string productName, productPrice;
        private string ISBN, author, publisher;
        private string page, cover;
        private static int ID;

        private _type type;

        public Book()
        {
        }

        public string Page
        {
            get => page;
            set => page = value;
        }

        public override string ProductPrice
        {
            get => productPrice;
            set => productPrice = value;
        }

        public int BookID
        {
            get => ID;
            set => ID = value;
        }

        public override string ProductName
        {
            get => productName;
            set => productName = value;
        }

        public string BookISBN
        {
            get => ISBN;
            set => ISBN = value;
        }

        public string Author
        {
            get => author;
            set => author = value;
        }

        public string Publisher
        {
            get => publisher;
            set => publisher = value;
        }

        public string Cover
        {
            get => cover;
            set => cover = value;
        }

        public _type Type
        {
            get => type;
            set => type = value;
        }
    }
}