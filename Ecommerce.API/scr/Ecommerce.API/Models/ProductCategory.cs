
namespace Ecommerce.API.Models
{
    public class ProductCategory : Entity
    {
        public String Category { get; private set; }
        public String Description { get; private set; }

        public List<Product> Products { get; private set; }
    }
}