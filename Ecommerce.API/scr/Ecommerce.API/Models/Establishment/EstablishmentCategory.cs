namespace Ecommerce.API.Models
{
    public class EstablishmentCategory : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<Establishment> Market { get; private set; }
    }
}