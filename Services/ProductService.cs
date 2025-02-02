namespace ECommerceApp.Services
{
    public class ProductService
    {
        public Task<List<Product>> GetProductsAsync()
        {
            return Task.FromResult(new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Description = "Description for product 1", Price = 10.99m },
                new Product { Id = 2, Name = "Product 2", Description = "Description for product 2", Price = 12.99m },
            });
        }
    }
}