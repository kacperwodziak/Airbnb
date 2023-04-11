using Airbnb.Models;
using Airbnb.Models.DTO;

namespace Airbnb.Service
{
    public interface IReservationService
    {
        public Task<ReservationResponseDTO> PostReservation(int id, ReservationRequestDTO reservationRequestDTO, CancellationToken cancellationToken);
    }
}
