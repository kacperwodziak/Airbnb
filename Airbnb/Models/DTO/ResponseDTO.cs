namespace Airbnb.Models.DTO
{
    public class UnAvailableDatesDTO
    {
        public List<DateTime> UnAvailableDates { get; set; }
    }
    public class ReservationResponseDTO
    {
        public string LocationName { get; set; }
        public string CustomerName { get; set; }
        public float Price { get; set; }
    }
}
