using Airbnb.Data;
using Airbnb.Interfaces;
using Airbnb.Models;
using Microsoft.EntityFrameworkCore;

namespace Airbnb.Repository
{
    public class ImageRepository : IImageRepository
    {
        private readonly AirbnbContext _context;
        public ImageRepository(AirbnbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Image>> GetAll(CancellationToken cancellationToken)
        {
            return await _context.Image.ToListAsync(cancellationToken);
        }
        public async Task<Image> GetById(int id, CancellationToken cancellationToken)
        {
            return await _context.Image.FindAsync(id, cancellationToken);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
