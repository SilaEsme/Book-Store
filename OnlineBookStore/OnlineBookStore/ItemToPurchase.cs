using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    class ItemToPurchase
    {
        Product product;
        int quantity;

        public ItemToPurchase() { }
        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }
    }
}
