using Airbnb.Models;
using Airbnb.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Airbnb.Services
{
    public interface ILocationService
    {
        public Task<IEnumerable<LocationDTO>> GetLocation(CancellationToken cancellationToken);
        public Task<IEnumerable<Location2DTO>> GetLocation2(CancellationToken cancellationToken);
        public Task<IEnumerable<Location>> GetAllLocations(CancellationToken cancellationToken);
        public Task<PriceDTO> GetMaxPrice(CancellationToken cancellationToken);
        public Task<DetailsDTO> GetDetails(int Id, CancellationToken cancellationToken);
        public Task<IEnumerable<Location2DTO>> SearchLocation(SearchDTO searchDTO, CancellationToken cancellationToken);
        public Task<UnAvailableDatesDTO> GetUnAvailableDates(int id, CancellationToken cancellationToken);
    }
}
