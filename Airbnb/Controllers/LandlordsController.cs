using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Airbnb.Data;
using Airbnb.Models;

namespace Airbnb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandlordsController : ControllerBase
    {
        private readonly AirbnbContext _context;

        public LandlordsController(AirbnbContext context)
        {
            _context = context;
        }

        // GET: api/Landlords
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Landlord>>> GetLandlord(CancellationToken cancellationToken)
        {
            return await _context.Landlord.ToListAsync(cancellationToken);
        }

        // GET: api/Landlords/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Landlord>> GetLandlord(int id, CancellationToken cancellationToken)
        {
            var landlord = await _context.Landlord.FindAsync(id, cancellationToken);

            if (landlord == null)
            {
                return NotFound();
            }

            return landlord;
        }
    }
}
