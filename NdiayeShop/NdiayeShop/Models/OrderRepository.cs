namespace NdiayeShop.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly NdiayeShopDbContext _ndiayeShopDbContext;
        private readonly IShoppingCart _shoppingCart;

        public OrderRepository(NdiayeShopDbContext ndiayeShopDbContext, IShoppingCart shoppingCart)
        {
            _ndiayeShopDbContext = ndiayeShopDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            List<ShoppingCartItem>? shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            foreach (ShoppingCartItem? shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    PieId = shoppingCartItem.Pie.PieId,
                    Price = shoppingCartItem.Pie.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            _ndiayeShopDbContext.Orders.Add(order);

            _ndiayeShopDbContext.SaveChanges();
        }
    }
}
