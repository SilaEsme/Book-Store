using System.Collections.Generic;

namespace OnlineBookStore
{
    internal class ShoppingCart
    {
        private Customer customer = Customer.CreateCustomer();
        private List<ItemToPurchase> list = new List<ItemToPurchase>();

        private enum PaymentType
        { cash, CreditCard }

        public ShoppingCart()
        {
        }
        public List<ItemToPurchase> List
        {
            get => list;
        }
        public void AddProduct(ItemToPurchase item)
        {
            list.Add(item);
        }

        public void RemoveProduct(ItemToPurchase item)
        {
            list.Remove(item);
        }

        public void PlaceOrder()
        {
        }

        public void CancelOrder()
        {
        }

        public void SendInvoiceBySMS()
        {
        }

        public void SendInvoiceByEMail()
        {
        }
    }
}