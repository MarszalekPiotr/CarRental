using CarRental.DataBase.Models;

namespace CarRental.Interfaces.Repositories
{
    public interface IRentalRepository
    {
        int Add(Rental rental);

    }
}
