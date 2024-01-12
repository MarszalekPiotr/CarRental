using Microsoft.AspNetCore.Identity;

namespace CarRental.DataBase.Models
{
    public class Rental
    {
        // Id, clientId, CarId, RentalDate, ReturnDate
        public int Id { get; set; }
        public string ClientId { get; set; }
        public Client Client { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
