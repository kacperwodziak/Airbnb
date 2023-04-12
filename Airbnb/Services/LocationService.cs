namespace Airbnb.Services
{
    using Airbnb.Interfaces;
    using Airbnb.Models;
    using Airbnb.Models.DTO;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;
        private readonly IMapper _mapper;
        public LocationService(ILocationRepository locationRepository, IMapper mapper)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<LocationDTO>> GetLocation(CancellationToken cancellationToken)
        {
            return (await _locationRepository.GetLocationAsync(cancellationToken)).Select(location => _mapper.Map<LocationDTO>(location));
        }
        public async Task<IEnumerable<Location2DTO>> GetLocation2(CancellationToken cancellationToken)
        {
            return (await _locationRepository.GetLocationAsync(cancellationToken)).Select(location => _mapper.Map<Location2DTO>(location));
        }
        public async Task<IEnumerable<Location>> GetAllLocations(CancellationToken cancellationToken)
        {
            return await _locationRepository.GetLocationAsync(cancellationToken);
        }
        public async Task<PriceDTO> GetMaxPrice(CancellationToken cancellationToken)
        {
            var locations = await _locationRepository.GetLocationAsync(cancellationToken);

            var maxPrice = locations.Max(l => l.PricePerDay);

            var response = new PriceDTO { Price = (int)maxPrice };

            return response;
        }
        public async Task<DetailsDTO> GetDetails(int id, CancellationToken cancellationToken)
        {
            var location = await _locationRepository.GetLocationByIdAsync(id, cancellationToken);

            var images = location.Images.Select(img => new ImagesDTO { URL = img.URL, IsCover = img.IsCover }).ToList();

            var landlord = new LandlordDTO
            {
                Name = $"{location.Landlord.FirstName} {location.Landlord.LastName}",
                Avatar = location.Landlord.Avatar.URL
            };

            var details = new DetailsDTO
            {
                Title = location.Title,
                SubTitle = location.SubTitle,
                Description = location.Description,
                Rooms = location.Rooms,
                NumberOfGuests = location.NumberOfGuests,
                PricePerDay = location.PricePerDay,
                Type = (int)location.Type,
                Features = (int)location.Features,
                Images = images,
                Landlord = landlord
            };

            return details;
        }

        public async Task<IEnumerable<Location2DTO>> SearchLocation(SearchDTO searchDTO, CancellationToken cancellationToken)
        {
            var locations = await _locationRepository.GetLocationAsync(cancellationToken);

            if (searchDTO.Features.HasValue)
            {
                locations = locations.Where(location => (int)location.Features == searchDTO.Features);
            }

            if (searchDTO.MinPrice.HasValue)
            {
                locations = locations.Where(location => location.PricePerDay >= searchDTO.MinPrice);
            }

            if (searchDTO.MaxPrice.HasValue)
            {
                locations = locations.Where(location => location.PricePerDay <= searchDTO.MaxPrice);
            }

            if (searchDTO.Type.HasValue)
            {
                locations = locations.Where(location => (int)location.Type == searchDTO.Type);
            }

            if (searchDTO.Rooms.HasValue)
            {
                locations = locations.Where(location => location.Rooms >= searchDTO.Rooms);
            }

            return locations.Select(location => _mapper.Map<Location2DTO>(location));
        }
        public async Task<UnAvailableDatesDTO> GetUnAvailableDates(int id, CancellationToken cancellationToken)
        {
            var location = await _locationRepository.GetLocationByIdAsync(id, cancellationToken);

            var reservations = location.Reservations;
            var unavailableDates = reservations.SelectMany(r => Enumerable.Range(0, (r.EndDate - r.StartDate).Days + 1).Select(i => r.StartDate.AddDays(i))).ToList();

            return new UnAvailableDatesDTO { UnAvailableDates = unavailableDates };
        }
    }
}
