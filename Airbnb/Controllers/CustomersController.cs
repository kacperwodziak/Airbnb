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
    public class CustomersController : ControllerBase
    {
        private readonly AirbnbContext _context;

        public CustomersController(AirbnbContext context)
        {
            _context = context;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomer(CancellationToken cancellationToken)
        {
            return await _context.Customer.ToListAsync(cancellationToken);
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id, CancellationToken cancellationToken)
        {
            var customer = await _context.Customer.FindAsync(id, cancellationToken);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }
    }
}
