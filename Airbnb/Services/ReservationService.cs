using Airbnb.Interfaces;
using Airbnb.Models.DTO;
using Airbnb.Models;
using AutoMapper;

namespace Airbnb.Service
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;
        public ReservationService (IMapper mapper, IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }
        public async Task<ReservationResponseDTO> PostReservation(ReservationRequestDTO reservationRequestDTO, CancellationToken cancellationToken)
        {

            //get a customer from the email  ZELF DOEN
            var customer = await _reservationRepository.GetCustomerByEmail(reservationRequestDTO.Email, cancellationToken);

            //get location from locationid ZLEF DOEN
            var location = await _reservationRepository.GetLocationById(reservationRequestDTO.LocationId, cancellationToken);
            //make from a reservationrequest a reservation
            //if the customer doesnt exist, add it 
            Reservation reservation = new Reservation
            {
                Customer = customer,
                Location = location,
                StarDate = reservationRequestDTO.StartDate,
                EndDate = reservationRequestDTO.EndDate
            };
            //await the add of the repository 
            _reservationRepository.Add(reservation, cancellationToken);
            _reservationRepository.Save();
            var post = new ReservationResponseDTO
            {
                LocationName = location.Title,
                CustomerName = customer.FirstName + " " + customer.LastName,
                Price = location.PricePerDay * (reservation.StarDate - reservation.EndDate).Days;               
            };

        return post;
        }
    }
}
