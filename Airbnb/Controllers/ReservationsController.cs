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
    public class ReservationsController : ControllerBase
    {
        private readonly AirbnbContext _context;

        public ReservationsController(AirbnbContext context)
        {
            _context = context;
        }

        //// GET: api/Reservations
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Reservation>>> GetReservations(CancellationToken cancellationToken)
        //{
        //    return await _context.Reservation.ToListAsync(cancellationToken);
        //}

        //// GET: api/Reservations/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Reservation>> GetReservations(int id, CancellationToken cancellationToken)
        //{
        //    var reservation = await _context.Reservation.FindAsync(id, cancellationToken);

        //    if (reservation == null)
        //    {
        //        return NotFound();
        //    }

        //    return reservation;
        //}
    }
}