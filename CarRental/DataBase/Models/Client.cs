using Microsoft.AspNetCore.Identity;

namespace CarRental.DataBase.Models
{
    public class Client: IdentityUser 
    { 
        public List<Rental> Rentals { get; set; }
        public List<Review> Reviews { get; set; }
    }
    
}
