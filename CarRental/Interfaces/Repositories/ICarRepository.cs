using CarRental.DataBase.Models;

namespace CarRental.Interfaces.Repositories
{
    public interface ICarRepository
    {
        int AddCar(Car car);


         void DeleteCar(int carId);
        

        int Update(Car car);


        void ChangeAvailabilityForTrue(int carId);


         Car GetCarById(int carId);

        List<Car> GetAllCars();
        List<Car> GetAllAvailableCars();



    }
}
