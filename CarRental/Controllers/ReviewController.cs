using CarRental.DataBase.Models;
using CarRental.Interfaces.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class ReviewController : Controller
    {     
        private ICarRepository carRepository;
        private IReviewRepository reviewRepository;
        UserManager<Client> _userManager;

        public ReviewController(ICarRepository carRepository, IReviewRepository reviewRepository, UserManager<Client> userManager)
        {
            this.carRepository = carRepository;
            this.reviewRepository = reviewRepository;
            _userManager = userManager;
        }

        // Oblusżyc niezalogowaneo uzytjownia
        [HttpGet]
        [Authorize]
        public IActionResult AddReview(int CarId)
        {
            string clientId = _userManager.GetUserId(User);
            Review review = new Review() { CarId = CarId , ClientId = clientId };
            return View(review);
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddReview(Review review)
        {
            reviewRepository.Add(review);
            //Q: przekierowanie do car details i tam opnie?
            return RedirectToAction("GetAvailableCars","Car");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
