

namespace Ecommerce.API.Models
{
    public class Customer : Entity 
    {
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
    }

    
}