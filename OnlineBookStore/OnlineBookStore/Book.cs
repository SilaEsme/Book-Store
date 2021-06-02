using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public enum _type { Fiction, Classic, Story, TurkishClassic, Education }
    public class Book : Product 
    {
        string name, ISBN, author, publisher;
        string page, price, cover;
        static int ID;

        _type type;

        
        public Book()
        {

        }
        public string Page
        {
            get => page;
            set => page = value;
        }
        public string Price
        {
            get => price;
            set => price = value;
        }
        public int BookID
        {
            get => ID;
            set => ID = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
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
