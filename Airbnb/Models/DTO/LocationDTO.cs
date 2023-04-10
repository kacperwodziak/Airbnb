using Airbnb.Models;

namespace Airbnb.Models.DTO
{
    public class LocationDTO
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string LandlordAvatarURL { get; set; }
    }
    public class Location2DTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string LandlordAvatarURL { get; set; }
        public float Price { get; set; }
        public int Type { get; set; }
    }
}
