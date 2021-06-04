using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace OnlineBookStore
{
    public class ShoppingCart
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
        private void GetList()
        {
            SqlCommand command = new SqlCommand("SELECT ProductName, Price, Amount, ProductType FROM dbo.ShoppingCart where Username = '" + Customer.CreateCustomer().userInfo.Username + "'", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                ProductFactory factory = new ProductFactory();
                Product product = factory.getProduct(dr.GetString(3));
                ItemToPurchase itemToPurchase = new ItemToPurchase();
                product.ProductName = dr.GetString(0);
                product.ProductPrice = dr.GetString(1);
                itemToPurchase.Product = product;
                itemToPurchase.Quantity = dr.GetString(2);
                AddProduct(itemToPurchase);
            }
            Database.CreateSingle().Sqlconnection.Close();
        }

        public void ListCart()
        {
            this.List.Clear();
            UserControlShoppingCart.Instance().flowLayoutPanelProducts.Controls.Clear();
            GetList();
            double totalprice = 0;
            int totalamount = 0;
            foreach (var item in List)
            {
                UserControlShoppingCartItem cartItem = new UserControlShoppingCartItem();
                cartItem.SetLabel(item.Product.ProductName, item.Product.ProductPrice, item.Quantity);
                UserControlShoppingCart.Instance().flowLayoutPanelProducts.Controls.Add(cartItem);
                item.Product.ProductPrice = item.Product.ProductPrice.Replace('.', ',');

                totalprice += Double.Parse(item.Product.ProductPrice) * Int32.Parse(item.Quantity);
                totalamount += Int32.Parse(item.Quantity);
            }
            UserControlShoppingCart.Instance().SetLabelPrice(totalprice.ToString().Replace(',', '.'));
            UserControlShoppingCart.Instance().SetLabelAmount(totalamount.ToString());
        }

        public void AddProduct(ItemToPurchase item)
        {
            list.Add(item);
        }

        public void RemoveProduct(ItemToPurchase item)
        {
            list.Remove(item);
        }
        public void ClearCart()
        {
            UserControlShoppingCart userControlShoppingCart = UserControlShoppingCart.Instance();
            List.Clear();
            userControlShoppingCart.flowLayoutPanelProducts.Controls.Clear();
            userControlShoppingCart.SetLabelAmount("0");
            userControlShoppingCart.SetLabelPrice("0");

            SqlCommand command = new SqlCommand("delete from shoppingcart FROM dbo.ShoppingCart where Username = '" + Customer.CreateCustomer().userInfo.Username + "'", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();
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