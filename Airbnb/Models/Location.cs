﻿namespace Airbnb.Models
{
    [Flags]
    public enum Features
    {
        Smoking = 1,
        PetsAllowed = 2,
        Wifi = 4,
        TV = 8,
        Bath = 16,
        Breakfast = 32
    }
    public enum LocationType
    {
        Apartment,
        Cottage,
        Chalet,
        Room,
        Hotel,
        House
    }
    public class Location
    {
        public int Id { get; set; }
        public Landlord Landlord { get; set; }
        public List<Image> Images { get; set; }
        public List<Reservation> Reservations { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set;  }
        public int Rooms { get; set; }
        public float PricePerDay { get; set; }
        public int NumberOfGuests { get; set; }
        public Features Features { get; set; }
        public LocationType Type { get; set; }
    }
}