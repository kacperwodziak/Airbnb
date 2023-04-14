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
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class Locations2Controller : ControllerBase
    {
        private readonly ILocationService _locationService;
        private readonly IMapper _mapper;

        public Locations2Controller(ILocationService locationService, IMapper mapper)
        {
            _locationService = locationService;
            _mapper = mapper;
        }

        /// <summary>
        /// Retrieves a list of all locations for the second version.
        /// </summary>
        /// <param name="cancellationToken">A CancellationToken object used to cancel the request if needed.</param>
        /// <returns>A list of all locations.</returns>
        //GET: api/Locations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location2DTO>>> GetLocation(CancellationToken cancellationToken)
        {
            try
            {
                var getLocation = await _locationService.GetLocation2(cancellationToken);

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
    }
}
