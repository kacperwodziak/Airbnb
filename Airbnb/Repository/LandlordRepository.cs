using Airbnb.Data;
using Airbnb.Interfaces;
using Airbnb.Models;
using Microsoft.EntityFrameworkCore;

namespace Airbnb.Repository
{
    public class LandlordRepository : ILandlordRepository
    {
        private readonly AirbnbContext _context;
        public LandlordRepository(AirbnbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Landlord>> GetAll(CancellationToken cancellationToken)
        {
            return await _context.Landlord.ToListAsync(cancellationToken);
        }
        public async Task<Landlord> GetById(int id, CancellationToken cancellationToken)
        {
            return await _context.Landlord.FindAsync(id, cancellationToken);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
