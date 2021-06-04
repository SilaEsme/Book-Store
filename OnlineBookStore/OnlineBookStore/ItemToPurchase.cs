/**
*  @author  : Sıla Eşme
*  @number  : 152120181004
*  @mail    : silaesme@gmail.com
*  @date    : 03.06.21
*  @brief   : It's for shopping item. 
*/
namespace OnlineBookStore
{
    /// <summary>
    /// It's class that contains Product type product and its amount.
    /// </summary>
    public class ItemToPurchase
    {
        private Product product;
        private string quantity;

        /// <summary>
        /// This is constructor.
        /// </summary>
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