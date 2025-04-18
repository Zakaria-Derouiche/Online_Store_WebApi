

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class User : IdentityUser
    {

       
        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        public List<Order> UserOrders { get; set; }

        public List<Review> UserReviews { get; set; }
    }
}
