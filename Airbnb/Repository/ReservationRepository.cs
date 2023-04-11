using Airbnb.Data;
using Airbnb.Interfaces;
using Airbnb.Models;
using Airbnb.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace Airbnb.Repository
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly AirbnbContext _context;
        public ReservationRepository(AirbnbContext context)
        {
            _context = context;
        }

      
        public void Add(Reservation reservation, CancellationToken cancellationToken)
        {
            _context.Add(reservation);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
