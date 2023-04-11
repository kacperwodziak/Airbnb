using Airbnb.Models;

namespace Airbnb.Interfaces
{
    public interface IReservationRepository
    {
        public void Add(Reservation reservation, CancellationToken cancellationToken);
        public void Save();
    }
}
