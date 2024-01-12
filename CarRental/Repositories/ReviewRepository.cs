using CarRental.DataBase;
using CarRental.DataBase.Models;
using CarRental.Interfaces.Repositories;

namespace CarRental.Repositories
{
    public class ReviewRepository : IReviewRepository
    {

        private readonly Context _context;

        public ReviewRepository(Context context)
        {
            _context = context;
        }

        public int Add(Review review)
        {
           _context.Reviews.Add(review);
           _context.SaveChanges();
            return review.Id;

        }

        public List<Review> GetReviewsForCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
