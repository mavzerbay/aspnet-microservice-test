namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
        }
        public ShoppingCart(string userName)
        {
            UserName = userName;
        }

        public string UserName { get; set; } = null!;
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

        #region Calculated Properties

        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                for (int i = 0; i < Items.Count; i++)
                {
                    totalPrice += Items[i].Price * Items[i].Quantity;
                }
                return totalPrice;
            }
        }
        #endregion
    }
}
