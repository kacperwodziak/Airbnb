using Airbnb.Models;

namespace Airbnb.Interfaces
{
    public interface IImageRepository
    {
        public Task<IEnumerable<Image>> GetAll(CancellationToken cancellationToken);
        public Task<Image> GetById(int id, CancellationToken cancellationToken);
        public void Save();
    }
}
