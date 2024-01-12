namespace CarRental.DataBase.Models
{
    public class Review
    {  
        public int Id { get; set; }
        public string ClientId { get; set; }
        public Client Client { get; set; } 
        public int CarId { get; set; }
        public Car Car { get; set; } 
        public int Rating { get; set; }
        public string Text { get; set; }


    }
}
