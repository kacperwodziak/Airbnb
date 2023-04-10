using Airbnb.Models;
using Airbnb.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Airbnb.Interfaces
{
    public interface ILocationRepository
    {
        public Task<IEnumerable<Location>> GetLocationAsync(CancellationToken cancellationToken);
        public Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken);
        public void Save();
    }
}
