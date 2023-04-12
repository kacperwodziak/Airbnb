using Airbnb.Data;
using Airbnb.Interfaces;
using Airbnb.Models;
using Microsoft.EntityFrameworkCore;

namespace Airbnb.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AirbnbContext _context;
        public CustomerRepository(AirbnbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Customer>> GetAll(CancellationToken cancellationToken)
        {
            return await _context.Customer.ToListAsync(cancellationToken);
        }
        public async Task<Customer> GetById(int id, CancellationToken cancellationToken)
        {
            return await _context.Customer.FindAsync(id, cancellationToken);
        }
        public async Task<Customer> GetEmailById(string email, CancellationToken cancellationToken)
        {
            return await _context.Customer.FirstOrDefaultAsync(c => c.Email == email, cancellationToken);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
