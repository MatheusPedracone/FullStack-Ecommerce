namespace Ecommerce.API.Models
{
    public class Product : Entity
    {
        public String Name { get; private set; } // private para não permitir que esses atributos                                                  
        public String Description { get; private set; } // sejam acessados fora da classe
        public double Price { get; private set; }
        public Guid ProductCategoryId { get; private set; }
        public ProductCategory ProductCategory { get; private set; }
    }
}