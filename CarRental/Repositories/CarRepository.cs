using CarRental.DataBase;
using CarRental.DataBase.Models;
using CarRental.Interfaces.Repositories;
using Microsoft.IdentityModel.Tokens;

namespace CarRental.Repositories
{
    public  class CarRepository : ICarRepository
    {
        private readonly Context _context;

         public  CarRepository(Context context)
        {
            _context = context;
        }

        public  int AddCar(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
            return car.Id;
        }

        public void DeleteCar(int carId)
        {
            Car car =   _context.Cars.FirstOrDefault(c => c.Id == carId);
            _context.Cars.Remove(car);
            _context.SaveChanges();

        }

        public int Update(Car carToUpdate)
        {
             _context.Cars.FirstOrDefault(C => C.Id == carToUpdate.Id).Availability = carToUpdate.Availability;
            _context.Cars.FirstOrDefault(C => C.Id == carToUpdate.Id).Year = carToUpdate.Year;
            _context.Cars.FirstOrDefault(C => C.Id == carToUpdate.Id).Brand = carToUpdate.Brand;
            _context.Cars.FirstOrDefault(C => C.Id == carToUpdate.Id).Image = carToUpdate.Image;
            _context.Cars.FirstOrDefault(C => C.Id == carToUpdate.Id).Colour = carToUpdate.Colour;
            _context.Cars.FirstOrDefault(C => C.Id == carToUpdate.Id).Description = carToUpdate.Description;
            _context.Cars.FirstOrDefault(C => C.Id == carToUpdate.Id).Model = carToUpdate.Model;
            _context.SaveChanges();
            return carToUpdate.Id;
        }

        public void ChangeAvailabilityForTrue(int carId)
        {
            _context.Cars.FirstOrDefault(c => c.Id == carId).Availability = true;
            _context.SaveChanges();
           
        }

        public Car GetCarById(int carId) 
        {
            return _context.Cars.FirstOrDefault(c => c.Id == carId);
        }
        public List<Car> GetAllCars()
        {
            return _context.Cars.ToList();
        }

        public List<Car> GetAllAvailableCars()
        {
            return _context.Cars.Where(c => c.Availability == true).ToList();
        }

    }
}
