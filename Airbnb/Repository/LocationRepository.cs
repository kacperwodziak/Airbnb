using Airbnb.Data;
using Airbnb.Interfaces;
using Airbnb.Models;
using Airbnb.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Airbnb.Repository
{
    public class LocationRepository : ILocationRepository
    {
        private readonly AirbnbContext _context;
        public LocationRepository(AirbnbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Location>> GetLocationAsync(CancellationToken cancellationToken)
        {
            return await _context.Location.Include(prop => prop.Landlord).ThenInclude(landlord => landlord.Avatar).Include(prop => prop.Images).ToListAsync(cancellationToken);
        }
        public async Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Location.Include(prop => prop.Images).Include(prop => prop.Landlord).ThenInclude(landlord => landlord.Avatar).Include(prop => prop.Reservations).FirstOrDefaultAsync(prop => prop.Id == id, cancellationToken);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}