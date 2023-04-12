﻿// <auto-generated />
using System;
using Airbnb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Airbnb.Migrations
{
    [DbContext(typeof(AirbnbContext))]
    [Migration("20230412202101_fixed")]
    partial class @fixed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Airbnb.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "casperspookje@gmail.com",
                            FirstName = "Casper",
                            LastName = "Spookje"
                        },
                        new
                        {
                            Id = 2,
                            Email = "gregegg@gmail.com",
                            FirstName = "Greg",
                            LastName = "Egg"
                        },
                        new
                        {
                            Id = 3,
                            Email = "ericboatman@gmail.com",
                            FirstName = "Eric",
                            LastName = "Boatman"
                        });
                });

            modelBuilder.Entity("Airbnb.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCover")
                        .HasColumnType("bit");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Image");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            IsCover = true,
                            LocationId = 1,
                            URL = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/22/a1/9c/80/essentia-luxury-hotel.jpg?w=700&h=-1&s=1"
                        },
                        new
                        {
                            Id = 4,
                            IsCover = true,
                            LocationId = 3,
                            URL = "https://sheholdsdearly.com/wp-content/uploads/2021/03/cottage-core-interior-design.jpg"
                        },
                        new
                        {
                            Id = 6,
                            IsCover = true,
                            LocationId = 5,
                            URL = "https://www.gossa.it/wp-content/uploads/chalets-suiten-chalet-berg-16.jpg"
                        },
                        new
                        {
                            Id = 8,
                            IsCover = true,
                            LocationId = 7,
                            URL = "https://blog.displate.com/wp-content/uploads/2022/02/Aesthetic-Bedroom-Ideas_41.jpg"
                        },
                        new
                        {
                            Id = 10,
                            IsCover = true,
                            LocationId = 9,
                            URL = "https://www.londontoolkit.com/lhr/crowne_plaza_t4_lhr.jpg"
                        },
                        new
                        {
                            Id = 12,
                            IsCover = true,
                            LocationId = 11,
                            URL = "https://www.bruzzesehomeimprovements.com/wp-content/uploads/2013/08/Craftsman-house.jpg"
                        },
                        new
                        {
                            Id = 14,
                            IsCover = true,
                            LocationId = 13,
                            URL = "https://www.essexapartmenthomes.com/-/media/Project/EssexPropertyTrust/Sites/EssexApartmentHomes/Blog/2021/2021-02-26-Renting-an-Apartment-in-Seattle/Renting-an-Apartment-in-Seattle-BellCentre-1.jpg"
                        },
                        new
                        {
                            Id = 16,
                            IsCover = true,
                            LocationId = 15,
                            URL = "https://www.gulleygreenhouse.com/wp-content/uploads/2021/06/cottagecore-header.jpg"
                        },
                        new
                        {
                            Id = 18,
                            IsCover = true,
                            LocationId = 17,
                            URL = "https://gallery.streamlinevrs.com/units-gallery/00/06/CB/image_157717014.jpeg"
                        },
                        new
                        {
                            Id = 20,
                            IsCover = true,
                            LocationId = 19,
                            URL = "https://i.pinimg.com/originals/35/15/bd/3515bd55db8db2903156e73847ce7ffa.jpg"
                        },
                        new
                        {
                            Id = 21,
                            IsCover = false,
                            LocationId = 1,
                            URL = "https://cdn.mos.cms.futurecdn.net/dEDEQowMrHzADNHvg8LZf9.jpg"
                        },
                        new
                        {
                            Id = 22,
                            IsCover = false,
                            LocationId = 1,
                            URL = "https://www.homeisthehamilton.com/corporate/uploads/SparkModelBedroom.jpg"
                        },
                        new
                        {
                            Id = 23,
                            IsCover = false,
                            LocationId = 3,
                            URL = "https://blog.displate.com/wp-content/uploads/2022/08/Cottagecore-Decor-Idea_2.jpg"
                        },
                        new
                        {
                            Id = 24,
                            IsCover = false,
                            LocationId = 3,
                            URL = "https://i.pinimg.com/736x/27/c2/99/27c299fb84d4d7ac60fb92bcf71d5961.jpg"
                        },
                        new
                        {
                            Id = 25,
                            IsCover = false,
                            LocationId = 5,
                            URL = "https://www.ovonetwork.com/blog/wp-content/uploads/2022/07/image-26.png"
                        },
                        new
                        {
                            Id = 26,
                            IsCover = false,
                            LocationId = 5,
                            URL = "https://cdn.homedit.com/wp-content/uploads/2017/10/Amazing-Bedroom-with-fireplace-Chalet-Trois-Couronnes-Verbier-Switzerland.jpg"
                        },
                        new
                        {
                            Id = 27,
                            IsCover = false,
                            LocationId = 9,
                            URL = "https://static.wikia.nocookie.net/backrooms/images/5/59/Level_188_classic.jpg"
                        },
                        new
                        {
                            Id = 28,
                            IsCover = false,
                            LocationId = 9,
                            URL = "https://digital.ihg.com/is/image/ihg/holiday-inn-express-hounslow-5714832623-4x3?fmt=jpg&jpegSize=500&qlt=85&resMode=sharp2&op_usm=1.75,0.3,2.0"
                        },
                        new
                        {
                            Id = 29,
                            IsCover = false,
                            LocationId = 11,
                            URL = "https://i0.wp.com/www.khov.com/blog/wp-content/uploads/2020/04/30993_Aspire-at-Ashley-Pointe_Ellwood_Family-Room-1024x655.jpg?resize=768%2C491&ssl=1"
                        },
                        new
                        {
                            Id = 30,
                            IsCover = false,
                            LocationId = 11,
                            URL = "https://i.pinimg.com/474x/9c/a3/72/9ca3723d2b666577207bfa65871aeab5.jpg"
                        },
                        new
                        {
                            Id = 31,
                            IsCover = false,
                            URL = "https://i.redd.it/qufda7imc8l71.jpg"
                        },
                        new
                        {
                            Id = 32,
                            IsCover = false,
                            URL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZjJ25xDzt_mDxxV6E9pYBpLIUT7gxJ5iuIykIpi8MNXK8oiBpGbq4M8ORdK2ozImOQ3E&usqp=CAU"
                        },
                        new
                        {
                            Id = 33,
                            IsCover = false,
                            URL = "https://steamuserimages-a.akamaihd.net/ugc/1839155758319318939/62B917FE2C2663BC82B608330B7589FADDF2D2DF/?imw=512&&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=false"
                        },
                        new
                        {
                            Id = 34,
                            IsCover = false,
                            URL = "https://static.wikia.nocookie.net/underthedome/images/1/11/Big_Jim_313_CROP.jpg/revision/latest?cb=20150913053305"
                        },
                        new
                        {
                            Id = 35,
                            IsCover = false,
                            URL = "https://steamuserimages-a.akamaihd.net/ugc/1474317626928641127/A8FF6D1FA0EBFCC33F3F69409757A1B45AD93D4E/?imw=512&&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=false"
                        });
                });

            modelBuilder.Entity("Airbnb.Models.Landlord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("AvatarId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.ToTable("Landlord");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 19,
                            AvatarId = 31,
                            FirstName = "Kacper",
                            LastName = "Wodziak"
                        },
                        new
                        {
                            Id = 2,
                            Age = 21,
                            AvatarId = 32,
                            FirstName = "Jeff",
                            LastName = "Mane"
                        },
                        new
                        {
                            Id = 3,
                            Age = 43,
                            AvatarId = 33,
                            FirstName = "Saul",
                            LastName = "Badman"
                        },
                        new
                        {
                            Id = 4,
                            Age = 67,
                            AvatarId = 34,
                            FirstName = "Jim",
                            LastName = "Grand"
                        },
                        new
                        {
                            Id = 5,
                            Age = 84,
                            AvatarId = 35,
                            FirstName = "Gertrude",
                            LastName = "Mullins"
                        });
                });

            modelBuilder.Entity("Airbnb.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Features")
                        .HasColumnType("int");

                    b.Property<int>("LandlordId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<float>("PricePerDay")
                        .HasColumnType("real");

                    b.Property<int>("Rooms")
                        .HasColumnType("int");

                    b.Property<string>("SubTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LandlordId");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A very open and spacious apartment with 5 rooms.",
                            Features = 30,
                            LandlordId = 3,
                            NumberOfGuests = 5,
                            PricePerDay = 99.99f,
                            Rooms = 5,
                            SubTitle = "Almere",
                            Title = "A nice apartment in the city.",
                            Type = 0
                        },
                        new
                        {
                            Id = 3,
                            Description = "It is as nice and cozy on the inside as it looks on the outside. It has 4 rooms.",
                            Features = 26,
                            LandlordId = 5,
                            NumberOfGuests = 4,
                            PricePerDay = 79.99f,
                            Rooms = 4,
                            SubTitle = "Almere",
                            Title = "A pretty cottage surrounded by trees.",
                            Type = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "Great place to relax and take your mind of things. It has 7 rooms and a porch",
                            Features = 58,
                            LandlordId = 4,
                            NumberOfGuests = 8,
                            PricePerDay = 139.99f,
                            Rooms = 7,
                            SubTitle = "Almere",
                            Title = "A chalet in the mountains with a calming atmosphere.",
                            Type = 2
                        },
                        new
                        {
                            Id = 7,
                            Description = "A nice and cozy room.",
                            Features = 60,
                            LandlordId = 3,
                            NumberOfGuests = 2,
                            PricePerDay = 19.99f,
                            Rooms = 1,
                            SubTitle = "Almere",
                            Title = "Very cozy room.",
                            Type = 3
                        },
                        new
                        {
                            Id = 9,
                            Description = "Level 188",
                            Features = 60,
                            LandlordId = 1,
                            NumberOfGuests = 2,
                            PricePerDay = 19.99f,
                            Rooms = 1,
                            SubTitle = "Almere",
                            Title = "Budget hotel room.",
                            Type = 4
                        },
                        new
                        {
                            Id = 11,
                            Description = "A spacious house with 8 rooms and a porch.",
                            Features = 62,
                            LandlordId = 2,
                            NumberOfGuests = 8,
                            PricePerDay = 159.99f,
                            Rooms = 8,
                            SubTitle = "Almere",
                            Title = "Large modern house.",
                            Type = 5
                        },
                        new
                        {
                            Id = 13,
                            Description = "Located in the city with 5 rooms.",
                            Features = 30,
                            LandlordId = 2,
                            NumberOfGuests = 5,
                            PricePerDay = 99.99f,
                            Rooms = 5,
                            SubTitle = "Almere",
                            Title = "Modern and colorful apartment.",
                            Type = 0
                        },
                        new
                        {
                            Id = 15,
                            Description = "Has 4 very cozy rooms and a pretty garden.",
                            Features = 26,
                            LandlordId = 5,
                            NumberOfGuests = 4,
                            PricePerDay = 79.99f,
                            Rooms = 4,
                            SubTitle = "Almere",
                            Title = "Beatiful cottage surrounded by wilderness.",
                            Type = 1
                        },
                        new
                        {
                            Id = 17,
                            Description = "Perfect place for a vacation. It has 7 rooms, a porch and indoor wood stoves.",
                            Features = 58,
                            LandlordId = 4,
                            NumberOfGuests = 8,
                            PricePerDay = 139.99f,
                            Rooms = 7,
                            SubTitle = "Almere",
                            Title = "A cozy chalet in the snowy mountains.",
                            Type = 2
                        },
                        new
                        {
                            Id = 19,
                            Description = "Kachow.",
                            Features = 60,
                            LandlordId = 1,
                            NumberOfGuests = 1,
                            PricePerDay = 19.99f,
                            Rooms = 1,
                            SubTitle = "Almere",
                            Title = "Very cool room.",
                            Type = 3
                        });
                });

            modelBuilder.Entity("Airbnb.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LocationId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("Airbnb.Models.Image", b =>
                {
                    b.HasOne("Airbnb.Models.Location", null)
                        .WithMany("Images")
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("Airbnb.Models.Landlord", b =>
                {
                    b.HasOne("Airbnb.Models.Image", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Avatar");
                });

            modelBuilder.Entity("Airbnb.Models.Location", b =>
                {
                    b.HasOne("Airbnb.Models.Landlord", "Landlord")
                        .WithMany("Locations")
                        .HasForeignKey("LandlordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Landlord");
                });

            modelBuilder.Entity("Airbnb.Models.Reservation", b =>
                {
                    b.HasOne("Airbnb.Models.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airbnb.Models.Location", "Location")
                        .WithMany("Reservations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Airbnb.Models.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Airbnb.Models.Landlord", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("Airbnb.Models.Location", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
