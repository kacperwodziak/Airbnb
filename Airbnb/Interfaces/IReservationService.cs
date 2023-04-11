using Airbnb.Models;
using Airbnb.Models.DTO;

namespace Airbnb.Services
{
    public interface IReservationService
    {
        public Task<ReservationResponseDTO> PostReservation(ReservationRequestDTO reservationRequestDTO, CancellationToken cancellationToken);
    }
}
