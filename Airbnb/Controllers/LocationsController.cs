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
using System.Threading;

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

        /// <summary>
        /// Retrieves a list of all locations.
        /// </summary>
        /// <param name="cancellationToken">A CancellationToken object used to cancel the request if needed.</param>
        /// <returns>A list of all locations.</returns>
        //GET: api/Locations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocationDTO>>> GetLocation(CancellationToken cancellationToken)
        {
            try
            {
                var getLocation = await _locationService.GetLocation(cancellationToken);

                if (getLocation == null)
                {
                    return NotFound();
                }

                return Ok(getLocation);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Retrieves a list of all locations.
        /// </summary>
        /// <param name="cancellationToken">A CancellationToken object used to cancel the request if needed.</param>
        /// <returns>A list of all locations.</returns>
        // GET: api/Locations/GetAll
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Location>>> GetAllLocations(CancellationToken cancellationToken)
        {
            try
            {
                var getAllLocations = await _locationService.GetAllLocations(cancellationToken);

                if (getAllLocations == null)
                {
                    return NotFound();
                }

                return Ok(getAllLocations);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Retrieves the price of the location with the highest price.
        /// </summary>
        /// <param name="cancellationToken">A CancellationToken object used to cancel the request if needed.</param>
        /// <returns>The price of the highest price location.</returns>
        // GET: api/Locations/GetMaxPrice
        [HttpGet("GetMaxPrice")]
        public async Task<ActionResult<IEnumerable<Location>>> GetMaxPrice(CancellationToken cancellationToken)
        {
            try
            {
                var maxPrice = await _locationService.GetMaxPrice(cancellationToken);

                if (maxPrice == null)
                {
                    return NotFound();
                }

                return Ok(maxPrice);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Retrieves the details of the requested location.
        /// </summary>
        /// <param name="id">The ID of the location to get the details for.</param>
        /// <param name="cancellationToken">A CancellationToken object used to cancel the request if needed.</param>
        /// <returns>A location object containing the details of the requested location.</returns>
        // GET: api/Locations/GetDetails/5
        [HttpGet("GetDetails/{id}")]
        public async Task<ActionResult<Location>> GetDetails(int id, CancellationToken cancellationToken)
        {
            try
            {
                var details = await _locationService.GetDetails(id, cancellationToken);

                if (details == null)
                {
                    return NotFound();
                }

                return Ok(details);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Retrieves the unavailable dates of the requested location
        /// </summary>
        /// <param name="id">The ID of the location to get the unavailable dates for.</param>
        /// <param name="cancellationToken">A CancellationToken object used to cancel the request if needed.</param>
        /// <returns>The unavailable dates of the requested location.</returns>
        // GET: apiLocations/UnAvailableDates/<locationId>
        [HttpGet("UnAvailableDates/{id}")]
        public async Task<ActionResult<UnAvailableDatesDTO>> GetUnAvailableDates(int id, CancellationToken cancellationToken)
        {
            try
            {
                var unAvailableDates = await _locationService.GetUnAvailableDates(id, cancellationToken);

                if (unAvailableDates == null)
                {
                    return NotFound();
                }

                return Ok(unAvailableDates);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Returns a list of locations based on the search criteria.
        /// </summary>
        /// <param name="searchDTO">A SearchDTO object containing the search criteria.</param>
        /// <param name="cancellationToken">A CancellationToken object used to cancel the request if needed.</param>
        /// <returns>A list of locations matching the search criteria.</returns>
        // POST: api/Locations/Search
        [HttpPost("Search")]
        public async Task<ActionResult<IEnumerable<Location>>> SearchLocation(SearchDTO searchDTO, CancellationToken cancellationToken)
        {
            try
            {
                var searchLocation = await _locationService.SearchLocation(searchDTO, cancellationToken);

                if (searchLocation == null)
                {
                    return NotFound();
                }

                return Ok(searchLocation);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
