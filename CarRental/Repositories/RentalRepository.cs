using CarRental.DataBase;
using CarRental.DataBase.Models;
using CarRental.Interfaces.Repositories;

namespace CarRental.Repositories
{
    public class RentalRepository : IRentalRepository
    {
        private readonly Context _context;
        public RentalRepository(Context context) 
        { 
          _context = context;
        }

        public int Add(Rental rental)
        {
            _context.Cars.FirstOrDefault(car => car.Id == rental.CarId).Availability = false;
            _context.Rentals.Add(rental);
            _context.SaveChanges();
            return rental.Id;
        }
    }
}
