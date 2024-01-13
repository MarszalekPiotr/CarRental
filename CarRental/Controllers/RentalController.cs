using CarRental.DataBase.Models;
using CarRental.Interfaces.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CarRental.Controllers
{
    public class RentalController : Controller
    {
        private IRentalRepository _rentalRepository;
        private UserManager<Client> _userManager;
        private readonly ICarRepository _carRepository;

        public RentalController(IRentalRepository rentalRepository, UserManager<Client> userManager, ICarRepository carRepository)
        {
            _rentalRepository = rentalRepository;
            _userManager = userManager;
            _carRepository = carRepository;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Rent(int CarId)
        {
            string clientId = _userManager.GetUserId(User);
            Rental rental = new Rental()
            {
              CarId = CarId ,
              ClientId = clientId};
            return View(rental);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Rent(Rental rental)
        {    
            _rentalRepository.Add(rental);
            return RedirectToAction("GetAvailableCars", "Car");
        }
    }
}
