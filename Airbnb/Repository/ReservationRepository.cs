using Airbnb.Data;
using Airbnb.Interfaces;
using Airbnb.Models;
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
        //public async Task<IEnumerable<Reservation>> GetAll(CancellationToken cancellationToken)
        //{
        //    return await _context.Reservation.ToListAsync(cancellationToken);
        //}
        //public async Task<Reservation> GetById(int id, CancellationToken cancellationToken)
        //{
        //    return await _context.Reservation.FindAsync(id, cancellationToken);
        //}
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
