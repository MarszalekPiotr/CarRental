using CarRental.DataBase.Models;

namespace CarRental.Interfaces.Repositories
{
    public interface IReviewRepository
    {
        int Add(Review review);
        List<Review> GetReviewsForCar (int carId);


    }
}
