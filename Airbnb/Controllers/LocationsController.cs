using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Airbnb.Data;
using Airbnb.Models;
using AutoMapper;
using Airbnb.Models.DTO;
using Airbnb.Services;

namespace Airbnb.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService _locationService;
        private readonly IMapper _mapper;

        public LocationsController(ILocationService locationService, IMapper mapper)
        {
            _locationService = locationService;
            _mapper = mapper;
        }

        //GET: api/Locations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocationDTO>>> GetLocation(CancellationToken cancellationToken)
        {
            var getLocation = await _locationService.GetLocation(cancellationToken);

            if (getLocation == null)
            {
                return NotFound();
            }

            return Ok(getLocation);
        }

        // GET: api/Locations/GetAll
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Location>>> GetAllLocations(CancellationToken cancellationToken)
        {
            var getAllLocations = await _locationService.GetAllLocations(cancellationToken);

            if (getAllLocations == null) 
            {
                return NotFound();
            }

            return Ok(getAllLocations);
        }

        // GET: api/Locations/GetMaxPrice
        [HttpGet("GetMaxPrice")]
        public async Task<ActionResult<IEnumerable<Location>>> GetMaxPrice(CancellationToken cancellationToken)
        {
            var maxPrice = await _locationService.GetMaxPrice(cancellationToken);

            if (maxPrice == null)
            {
                return NotFound();
            }

            return Ok(maxPrice);
        }

        // GET: api/Locations/GetDetails/5
        [HttpGet("GetDetails/{id}")]
        public async Task<ActionResult<Location>> GetDetails(int id, CancellationToken cancellationToken)
        {
            var details = await _locationService.GetDetails(id, cancellationToken);

            if (details == null)
            {
                return NotFound();
            }

            return Ok(details);
        }

        // GET: apiLocations/UnAvailableDates/<locationId>


        // POST: api/Locations/Search
        [HttpPost("Search")]
        public async Task<ActionResult<IEnumerable<Location>>> SearchLocation(SearchDTO searchDTO, CancellationToken cancellationToken)
        {
            var searchLocation = await _locationService.SearchLocation(searchDTO, cancellationToken);

            if (searchLocation == null)
            {
                return NotFound();
            }

            return Ok(searchLocation);
        }
    }
}
