using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public class ShoppingCart
    {
        private Customer customer = Customer.CreateCustomer();
        private List<ItemToPurchase> list = new List<ItemToPurchase>();

        private static ShoppingCart shoppingCart;
        public static ShoppingCart CreateShoppingCart()
        {
            if (shoppingCart == null)
                shoppingCart = new ShoppingCart();
            return shoppingCart;
        }
        private enum PaymentType
        { cash, CreditCard }

        protected ShoppingCart()
        {
        }

        public List<ItemToPurchase> List
        {
            get => list;
        }
        private void GetList()
        {
            SqlCommand command = new SqlCommand("SELECT ProductName, Price, Amount, ProductType FROM dbo.ShoppingCart where OrderNo is NULL and Username = '" + Customer.CreateCustomer().userInfo.Username + "'", Database.CreateSingle().Sqlconnection);
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
        public void ClearCart(int no)
        {
            UserControlShoppingCart userControlShoppingCart = UserControlShoppingCart.Instance();
            List.Clear();
            userControlShoppingCart.flowLayoutPanelProducts.Controls.Clear();
            userControlShoppingCart.SetLabelAmount("0");
            userControlShoppingCart.SetLabelPrice("0");

            SqlCommand command = new SqlCommand("delete FROM dbo.ShoppingCart where Username = @username and OrderNo = @no", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);
            command.Parameters.AddWithValue("@no", no);
            Database.CreateSingle().Sqlconnection.Open();
            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();
        }
        public void ClearCart()
        {
            UserControlShoppingCart userControlShoppingCart = UserControlShoppingCart.Instance();
            List.Clear();
            userControlShoppingCart.flowLayoutPanelProducts.Controls.Clear();
            userControlShoppingCart.SetLabelAmount("0");
            userControlShoppingCart.SetLabelPrice("0");

            SqlCommand command = new SqlCommand("delete FROM dbo.ShoppingCart where Username = @username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);
            Database.CreateSingle().Sqlconnection.Open();
            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();
        }

        public void PlaceOrder(string invoice)
        {
            MessageBox.Show("Your Order has been created! " + invoice, "New Order", MessageBoxButtons.OK);
        }

        public void CancelOrder(int no)
        {
            ClearCart(no);
            SqlCommand command = new SqlCommand("DELETE from OrderList where OrderNumber = @no", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@no", no);
            Database.CreateSingle().Sqlconnection.Open();
            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();
        }

        public string SendInvoiceBySMS()
        {
            return "Your invoice will be sent via SMS.";
        }

        public string SendInvoiceByEMail()
        {
            return "Your invoice will be sent via E-Mail.";
        }
    }
}