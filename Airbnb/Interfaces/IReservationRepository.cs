using Airbnb.Models;
using Airbnb.Models.DTO;

namespace Airbnb.Interfaces
{
    public interface IReservationRepository
    {
        public void Add(Reservation reservation, CancellationToken cancellationToken);
        public void Save();
    }
}
