using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Airbnb.Data;
using Airbnb.Models;
using Airbnb.Models.DTO;
using Airbnb.Services;
using System.Threading;
using AutoMapper;
using System.Reflection.Metadata.Ecma335;

namespace Airbnb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        private readonly IMapper _mapper;

        public ReservationsController(IReservationService reservationService, IMapper mapper)
        {
            _reservationService = reservationService;
            _mapper = mapper;
        }

        // POST: api/Reservations
        [HttpPost]
        public async Task<ActionResult<ReservationResponseDTO>> PostReservation(ReservationRequestDTO reservationRequestDTO, CancellationToken cancellationToken)
        {
            try
            {
                ReservationResponseDTO reservation;

                reservation = await _reservationService.PostReservation(reservationRequestDTO, cancellationToken);

                if (reservation == null)
                {
                    return NotFound();
                }

                return Ok(reservation);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}