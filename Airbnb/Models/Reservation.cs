﻿namespace Airbnb.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public Location Location { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public Customer Customer { get; set; }
    }
}