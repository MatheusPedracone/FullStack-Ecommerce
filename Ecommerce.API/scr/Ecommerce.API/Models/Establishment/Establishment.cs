namespace Ecommerce.API.Models
{
    public class Establishment : Entity
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public List<Product> Products { get; private set; }
        public List<Rating> Ratings { get; private set; }
        public Guid EstablishmentCategoryId { get; private set; }
        public EstablishmentCategory EstablishmentCategory { get; private set; }
    }
}