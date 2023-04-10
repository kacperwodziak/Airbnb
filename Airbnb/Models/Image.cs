    namespace Airbnb.Models
{
    public class Image
    {
        public int Id { get; set; }
        public Location? Location { get; set; }
        public string URL { get; set; }
        public bool IsCover { get; set; }
    }
}
