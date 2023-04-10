using Airbnb.Models;

namespace Airbnb.Interfaces
{
    public interface ILandlordRepository
    {
        public Task<IEnumerable<Landlord>> GetAll(CancellationToken cancellationToken);
        public Task<Landlord> GetById(int id, CancellationToken cancellationToken);
        public void Save();
    }
}
