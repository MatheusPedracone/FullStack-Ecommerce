namespace Ecommerce.API.Models
{
    public class ProductCategory : Entity
    {
        public string Category { get; private set; }
        public string Description { get; private set; }
        public List<Product> Products { get; private set; }
    }
}