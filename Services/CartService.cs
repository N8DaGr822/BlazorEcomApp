namespace ECommerceApp.Services
{
    public class CartService
    {
        private readonly List<Product> cart = new List<Product>();

        public void AddToCart(Product product)
        {
            cart.Add(product);
        }

        public List<Product> GetCartItems()
        {
            return new List<Product>(cart);
        }

        public void ClearCart()
        {
            cart.Clear();
        }
    }
}
