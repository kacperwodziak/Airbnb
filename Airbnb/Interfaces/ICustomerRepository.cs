using Airbnb.Models;

namespace Airbnb.Interfaces
{
    public interface ICustomerRepository
    {
        public Task<IEnumerable<Customer>> GetAll(CancellationToken cancellationToken);
        public Task<Customer> GetById(int id, CancellationToken cancellationToken);
        public void Save();
    }
}
