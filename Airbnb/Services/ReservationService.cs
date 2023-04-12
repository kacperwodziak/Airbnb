using Airbnb.Interfaces;
using Airbnb.Models.DTO;
using Airbnb.Models;
using AutoMapper;
using Airbnb.Repository;

namespace Airbnb.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly ILocationRepository _locationRepository;
        private readonly IMapper _mapper;
        public ReservationService(IReservationRepository reservationRepository, ICustomerRepository customerRepository, ILocationRepository locationRepository, IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _customerRepository = customerRepository;
            _locationRepository = locationRepository;
            _mapper = mapper;
        }
        public async Task<ReservationResponseDTO> PostReservation(ReservationRequestDTO reservationRequestDTO, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetEmailById(reservationRequestDTO.Email, cancellationToken);

            var location = await _locationRepository.GetLocationByIdAsync(reservationRequestDTO.LocationId, cancellationToken);

            if (customer == null) {
                customer = new Customer
                {
                    FirstName = reservationRequestDTO.FirstName,
                    LastName = reservationRequestDTO.LastName,
                    Email = reservationRequestDTO.Email
                };
            }

        Reservation reservation = new Reservation
            {
                Location = location,
                StartDate = reservationRequestDTO.StartDate,
                EndDate = reservationRequestDTO.EndDate,
                Customer = customer
            };

            _reservationRepository.Add(reservation, cancellationToken);
            _reservationRepository.Save();

            var post = new ReservationResponseDTO
            {
                LocationName = location.Title,
                CustomerName = customer.FirstName + " " + customer.LastName,
                Price = location.PricePerDay * (reservation.EndDate - reservation.StartDate).Days
            };
            return post;
        }
    }
}