using Airbnb.Models;

namespace Airbnb.Interfaces
{
    public interface IReservationRepository
    {
        //public Task<IEnumerable<Reservation>> GetAll(CancellationToken cancellationToken);
        //public Task<Reservation> GetById(int id, CancellationToken cancellationToken);
        public void Save();
    }
}
