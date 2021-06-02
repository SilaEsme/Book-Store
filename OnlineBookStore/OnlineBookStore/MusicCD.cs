namespace OnlineBookStore
{
    public enum typeCD { Rock, Classical, Pop, Country, Jazz, Rap, Punk, Metal }

    public class MusicCD : Product
    {
        private string productName, productPrice;
        private static int ID;
        private string singer;

        private typeCD typecd;

        public typeCD Type
        {
            get => typecd;
            set => typecd = value;
        }

        public MusicCD()
        {
        }

        public override string ProductName
        {
            get => productName;
            set => productName = value;
        }

        public string Singer
        {
            get => singer;
            set => singer = value;
        }

        public int MusicCDID
        {
            get => ID;
            set => ID = value;
        }

        public override string ProductPrice
        {
            get => productPrice;
            set => productPrice = value;
        }
    }
}