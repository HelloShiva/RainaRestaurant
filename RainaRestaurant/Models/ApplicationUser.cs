using Microsoft.AspNetCore.Identity;

namespace RainaRestaurant.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order>? Orders { get; set; }
    }
}
