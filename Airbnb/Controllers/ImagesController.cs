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
    public class ImagesController : ControllerBase
    {
        private readonly AirbnbContext _context;

        public ImagesController(AirbnbContext context)
        {
            _context = context;
        }

        // GET: api/Images
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Image>>> GetImage(CancellationToken cancellationToken)
        {
            return await _context.Image.ToListAsync(cancellationToken);
        }

        // GET: api/Images/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Image>> GetImage(int id, CancellationToken cancellationToken)
        {
            var image = await _context.Image.FindAsync(id, cancellationToken);

            if (image == null)
            {
                return NotFound();
            }

            return image;
        }
    }
}
