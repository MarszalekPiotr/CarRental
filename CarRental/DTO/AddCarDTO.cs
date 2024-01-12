namespace CarRental.DTO
{
    public class AddCarDTO
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
        public bool Availability { get; set; }
        public IFormFile Image { get; set; }
        public string Description { get; set; }
    }
}
