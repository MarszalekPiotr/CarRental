using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.DataBase.Models
{
    public class Car
    {
        
        public int Id { get; set; } 
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
        public bool Availability { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
     
        public List<Rental> Rentals { get; set; }
      
        public List<Review> Reviews { get; set; }


    }
}
