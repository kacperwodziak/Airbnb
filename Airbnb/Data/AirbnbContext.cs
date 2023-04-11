using Airbnb.Models;
using Microsoft.EntityFrameworkCore;

namespace Airbnb.Data
{
    public class AirbnbContext : DbContext
    {
        public AirbnbContext(DbContextOptions<AirbnbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Airbnb.Data;Integrated Security=SSPI;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Airbnb.Models.Landlord> Landlord { get; set; }

        public DbSet<Airbnb.Models.Location> Location { get; set; }

        public DbSet<Airbnb.Models.Customer> Customer { get; set; }

        public DbSet<Airbnb.Models.Image> Image { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasData(
                new
                {
                    Id = 1,
                    FirstName = "Casper",
                    LastName = "Spookje",
                    Email = "casperspookje@gmail.com",
                },
                new
                {
                    Id = 2,
                    FirstName = "Greg",
                    LastName = "Egg",
                    Email = "gregegg@gmail.com",
                },
                new
                {
                    Id = 3,
                    FirstName = "Eric",
                    LastName = "Boatman",
                    Email = "ericboatman@gmail.com",
                }
            );
            modelBuilder.Entity<Image>().HasData(
                new
                {
                    Id = 2,
                    LocationId = 1,
                    URL = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/22/a1/9c/80/essentia-luxury-hotel.jpg?w=700&h=-1&s=1",
                    IsCover = true,
                },
                new
                {
                    Id = 4,
                    LocationId = 3,
                    URL = "https://sheholdsdearly.com/wp-content/uploads/2021/03/cottage-core-interior-design.jpg",
                    IsCover = true,
                },
                new
                {
                    Id = 6,
                    LocationId = 5,
                    URL = "https://www.gossa.it/wp-content/uploads/chalets-suiten-chalet-berg-16.jpg",
                    IsCover = true,
                },
                new
                {
                    Id = 8,
                    LocationId = 7,
                    URL = "https://blog.displate.com/wp-content/uploads/2022/02/Aesthetic-Bedroom-Ideas_41.jpg",
                    IsCover = true,
                },
                new
                {
                    Id = 10,
                    LocationId = 9,
                    URL = "https://www.londontoolkit.com/lhr/crowne_plaza_t4_lhr.jpg",
                    IsCover = true,
                },
                new
                {
                    Id = 12,
                    LocationId = 11,
                    URL = "https://www.bruzzesehomeimprovements.com/wp-content/uploads/2013/08/Craftsman-house.jpg",
                    IsCover = true,
                },
                new
                {
                    Id = 14,
                    LocationId = 13,
                    URL = "https://www.essexapartmenthomes.com/-/media/Project/EssexPropertyTrust/Sites/EssexApartmentHomes/Blog/2021/2021-02-26-Renting-an-Apartment-in-Seattle/Renting-an-Apartment-in-Seattle-BellCentre-1.jpg",
                    IsCover = true,
                },
                new
                {
                    Id = 16,
                    LocationId = 15,
                    URL = "https://www.gulleygreenhouse.com/wp-content/uploads/2021/06/cottagecore-header.jpg",
                    IsCover = true,
                },
                new
                {
                    Id = 18,
                    LocationId = 17,
                    URL = "https://gallery.streamlinevrs.com/units-gallery/00/06/CB/image_157717014.jpeg",
                    IsCover = true,
                },
                new
                {
                    Id = 20,
                    LocationId = 19,
                    URL = "https://i.pinimg.com/originals/35/15/bd/3515bd55db8db2903156e73847ce7ffa.jpg",
                    IsCover = true,
                },
                new
                {
                    Id = 21,
                    LocationId = 1,
                    URL = "https://cdn.mos.cms.futurecdn.net/dEDEQowMrHzADNHvg8LZf9.jpg",
                    IsCover = false,
                },
                new
                {
                    Id = 22,
                    LocationId = 1,
                    URL = "https://www.homeisthehamilton.com/corporate/uploads/SparkModelBedroom.jpg",
                    IsCover = false,
                },
                new
                {
                    Id = 23,
                    LocationId = 3,
                    URL = "https://blog.displate.com/wp-content/uploads/2022/08/Cottagecore-Decor-Idea_2.jpg",
                    IsCover = false,
                },
                new
                {
                    Id = 24,
                    LocationId = 3,
                    URL = "https://i.pinimg.com/736x/27/c2/99/27c299fb84d4d7ac60fb92bcf71d5961.jpg",
                    IsCover = false,
                },
                new
                {
                    Id = 25,
                    LocationId = 5,
                    URL = "https://www.ovonetwork.com/blog/wp-content/uploads/2022/07/image-26.png",
                    IsCover = false,
                },
                new
                {
                    Id = 26,
                    LocationId = 5,
                    URL = "https://cdn.homedit.com/wp-content/uploads/2017/10/Amazing-Bedroom-with-fireplace-Chalet-Trois-Couronnes-Verbier-Switzerland.jpg",
                    IsCover = false,
                },
                new
                {
                    Id = 27,
                    LocationId = 9,
                    URL = "https://static.wikia.nocookie.net/backrooms/images/5/59/Level_188_classic.jpg",
                    IsCover = false,
                },
                new
                {
                    Id = 28,
                    LocationId = 9,
                    URL = "https://digital.ihg.com/is/image/ihg/holiday-inn-express-hounslow-5714832623-4x3?fmt=jpg&jpegSize=500&qlt=85&resMode=sharp2&op_usm=1.75,0.3,2.0",
                    IsCover = false,
                },
                new
                {
                    Id = 29,
                    LocationId = 11,
                    URL = "https://i0.wp.com/www.khov.com/blog/wp-content/uploads/2020/04/30993_Aspire-at-Ashley-Pointe_Ellwood_Family-Room-1024x655.jpg?resize=768%2C491&ssl=1",
                    IsCover = false,
                },
                new
                {
                    Id = 30,
                    LocationId = 11,
                    URL = "https://i.pinimg.com/474x/9c/a3/72/9ca3723d2b666577207bfa65871aeab5.jpg",
                    IsCover = false,
                },
                new
                {
                    Id = 31,
                    URL = "https://i.redd.it/qufda7imc8l71.jpg",
                    IsCover = false,
                },
                new
                {
                    Id = 32,
                    URL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZjJ25xDzt_mDxxV6E9pYBpLIUT7gxJ5iuIykIpi8MNXK8oiBpGbq4M8ORdK2ozImOQ3E&usqp=CAU",
                    IsCover = false,
                },
                new
                {
                    Id = 33,
                    URL = "https://steamuserimages-a.akamaihd.net/ugc/1839155758319318939/62B917FE2C2663BC82B608330B7589FADDF2D2DF/?imw=512&&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=false",
                    IsCover = false,
                },
                new
                {
                    Id = 34,
                    URL = "https://static.wikia.nocookie.net/underthedome/images/1/11/Big_Jim_313_CROP.jpg/revision/latest?cb=20150913053305",
                    IsCover = false,
                },
                new
                {
                    Id = 35,
                    URL = "https://steamuserimages-a.akamaihd.net/ugc/1474317626928641127/A8FF6D1FA0EBFCC33F3F69409757A1B45AD93D4E/?imw=512&&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=false",
                    IsCover = false,
                }
            );
            modelBuilder.Entity<Landlord>().HasData(
                new
                {
                    Id = 1,
                    AvatarId = 31,
                    FirstName = "Kacper",
                    LastName = "Wodziak",
                    Age = 19,
                },
                new
                {
                    Id = 2,
                    AvatarId = 32,
                    FirstName = "Jeff",
                    LastName = "Mane",
                    Age = 21,
                },
                new
                {
                    Id = 3,
                    AvatarId = 33,
                    FirstName = "Saul",
                    LastName = "Badman",
                    Age = 43,
                },
                new
                {
                    Id = 4,
                    AvatarId = 34,
                    FirstName = "Jim",
                    LastName = "Grand",
                    Age = 67,
                },
                new
                {
                    Id = 5,
                    AvatarId = 35,
                    FirstName = "Gertrude",
                    LastName = "Mullins",
                    Age = 84,
                }
            );
            modelBuilder.Entity<Location>().HasData(
                new
                {
                    Id = 1,
                    LandlordId = 3,
                    Title = "A nice apartment in the city.",
                    SubTitle = "Almere",
                    Description = "A very open and spacious apartment with 5 rooms.",
                    Rooms = 5,
                    PricePerDay = 99.99f,
                    NumberOfGuests = 5,
                    Features = (Features)30,
                    Type = LocationType.Apartment,
                },
                new
                {
                    Id = 3,
                    LandlordId = 5,
                    Title = "A pretty cottage surrounded by trees.",
                    SubTitle = "Almere",
                    Description = "It is as nice and cozy on the inside as it looks on the outside. It has 4 rooms.",
                    Rooms = 4,
                    PricePerDay = 79.99f,
                    NumberOfGuests = 4,
                    Features = (Features)26,
                    Type = LocationType.Cottage,
                },
                new
                {
                    Id = 5,
                    LandlordId = 4,
                    Title = "A chalet in the mountains with a calming atmosphere.",
                    SubTitle = "Almere",
                    Description = "Great place to relax and take your mind of things. It has 7 rooms and a porch",
                    Rooms = 7,
                    PricePerDay = 139.99f,
                    NumberOfGuests = 8,
                    Features = (Features)58,
                    Type = LocationType.Chalet,
                },
                new
                {
                    Id = 7,
                    LandlordId = 3,
                    Title = "Very cozy room.",
                    SubTitle = "Almere",
                    Description = "A nice and cozy room.",
                    Rooms = 1,
                    PricePerDay = 19.99f,
                    NumberOfGuests = 2,
                    Features = (Features)60,
                    Type = LocationType.Room,
                },
                new
                {
                    Id = 9,
                    LandlordId = 1,
                    Title = "Budget hotel room.",
                    SubTitle = "Almere",
                    Description = "Level 188",
                    Rooms = 1,
                    PricePerDay = 19.99f,
                    NumberOfGuests = 2,
                    Features = (Features)60,
                    Type = LocationType.Hotel,
                },
                new
                {
                    Id = 11,
                    LandlordId = 2,
                    Title = "Large modern house.",
                    SubTitle = "Almere",
                    Description = "A spacious house with 8 rooms and a porch.",
                    Rooms = 8,
                    PricePerDay = 159.99f,
                    NumberOfGuests = 8,
                    Features = (Features)62,
                    Type = LocationType.House,
                },
                new
                {
                    Id = 13,
                    LandlordId = 2,
                    Title = "Modern and colorful apartment.",
                    SubTitle = "Almere",
                    Description = "Located in the city with 5 rooms.",
                    Rooms = 5,
                    PricePerDay = 99.99f,
                    NumberOfGuests = 5,
                    Features = (Features)30,
                    Type = LocationType.Apartment,
                },
                new
                {
                    Id = 15,
                    LandlordId = 5,
                    Title = "Beatiful cottage surrounded by wilderness.",
                    SubTitle = "Almere",
                    Description = "Has 4 very cozy rooms and a pretty garden.",
                    Rooms = 4,
                    PricePerDay = 79.99f,
                    NumberOfGuests = 4,
                    Features = (Features)26,
                    Type = LocationType.Cottage,
                },
                new
                {
                    Id = 17,
                    LandlordId = 4,
                    Title = "A cozy chalet in the snowy mountains.",
                    SubTitle = "Almere",
                    Description = "Perfect place for a vacation. It has 7 rooms, a porch and indoor wood stoves.",
                    Rooms = 7,
                    PricePerDay = 139.99f,
                    NumberOfGuests = 8,
                    Features = (Features)58,
                    Type = LocationType.Chalet,
                },
                new
                {
                    Id = 19,
                    LandlordId = 1,
                    Title = "Very cool room.",
                    SubTitle = "Almere",
                    Description = "Kachow.",
                    Rooms = 1,
                    PricePerDay = 19.99f,
                    NumberOfGuests = 1,
                    Features = (Features)60,
                    Type = LocationType.Room,
                }
            );
        }
    }
}
