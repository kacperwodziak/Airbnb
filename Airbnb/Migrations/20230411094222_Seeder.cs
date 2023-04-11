using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Airbnb.Migrations
{
    /// <inheritdoc />
    public partial class Seeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "casperspookje@gmail.com", "Casper", "Spookje" },
                    { 2, "gregegg@gmail.com", "Greg", "Egg" },
                    { 3, "ericboatman@gmail.com", "Eric", "Boatman" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "IsCover", "LocationId", "URL" },
                values: new object[,]
                {
                    { 31, false, null, "https://i.redd.it/qufda7imc8l71.jpg" },
                    { 32, false, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZjJ25xDzt_mDxxV6E9pYBpLIUT7gxJ5iuIykIpi8MNXK8oiBpGbq4M8ORdK2ozImOQ3E&usqp=CAU" },
                    { 33, false, null, "https://steamuserimages-a.akamaihd.net/ugc/1839155758319318939/62B917FE2C2663BC82B608330B7589FADDF2D2DF/?imw=512&&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=false" },
                    { 34, false, null, "https://static.wikia.nocookie.net/underthedome/images/1/11/Big_Jim_313_CROP.jpg/revision/latest?cb=20150913053305" },
                    { 35, false, null, "https://steamuserimages-a.akamaihd.net/ugc/1474317626928641127/A8FF6D1FA0EBFCC33F3F69409757A1B45AD93D4E/?imw=512&&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=false" }
                });

            migrationBuilder.InsertData(
                table: "Landlord",
                columns: new[] { "Id", "Age", "AvatarId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 19, 31, "Kacper", "Wodziak" },
                    { 2, 21, 32, "Jeff", "Mane" },
                    { 3, 43, 33, "Saul", "Badman" },
                    { 4, 67, 34, "Jim", "Grand" },
                    { 5, 84, 35, "Gertrude", "Mullins" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Description", "Features", "LandlordId", "NumberOfGuests", "PricePerDay", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[,]
                {
                    { 1, "A very open and spacious apartment with 5 rooms.", 30, 3, 5, 99.99f, 5, "Almere", "A nice apartment in the city.", 0 },
                    { 3, "It is as nice and cozy on the inside as it looks on the outside. It has 4 rooms.", 26, 5, 4, 79.99f, 4, "Almere", "A pretty cottage surrounded by trees.", 1 },
                    { 5, "Great place to relax and take your mind of things. It has 7 rooms and a porch", 58, 4, 8, 139.99f, 7, "Almere", "A chalet in the mountains with a calming atmosphere.", 2 },
                    { 7, "A nice and cozy room.", 60, 3, 2, 19.99f, 1, "Almere", "Very cozy room.", 3 },
                    { 9, "Level 188", 60, 1, 2, 19.99f, 1, "Almere", "Budget hotel room.", 4 },
                    { 11, "A spacious house with 8 rooms and a porch.", 62, 2, 8, 159.99f, 8, "Almere", "Large modern house.", 5 },
                    { 13, "Located in the city with 5 rooms.", 30, 2, 5, 99.99f, 5, "Almere", "Modern and colorful apartment.", 0 },
                    { 15, "Has 4 very cozy rooms and a pretty garden.", 26, 5, 4, 79.99f, 4, "Almere", "Beatiful cottage surrounded by wilderness.", 1 },
                    { 17, "Perfect place for a vacation. It has 7 rooms, a porch and indoor wood stoves.", 58, 4, 8, 139.99f, 7, "Almere", "A cozy chalet in the snowy mountains.", 2 },
                    { 19, "Kachow.", 60, 1, 1, 19.99f, 1, "Almere", "Very cool room.", 3 }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "IsCover", "LocationId", "URL" },
                values: new object[,]
                {
                    { 2, true, 1, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/22/a1/9c/80/essentia-luxury-hotel.jpg?w=700&h=-1&s=1" },
                    { 4, true, 3, "https://sheholdsdearly.com/wp-content/uploads/2021/03/cottage-core-interior-design.jpg" },
                    { 6, true, 5, "https://www.gossa.it/wp-content/uploads/chalets-suiten-chalet-berg-16.jpg" },
                    { 8, true, 7, "https://blog.displate.com/wp-content/uploads/2022/02/Aesthetic-Bedroom-Ideas_41.jpg" },
                    { 10, true, 9, "https://www.londontoolkit.com/lhr/crowne_plaza_t4_lhr.jpg" },
                    { 12, true, 11, "https://www.bruzzesehomeimprovements.com/wp-content/uploads/2013/08/Craftsman-house.jpg" },
                    { 14, true, 13, "https://www.essexapartmenthomes.com/-/media/Project/EssexPropertyTrust/Sites/EssexApartmentHomes/Blog/2021/2021-02-26-Renting-an-Apartment-in-Seattle/Renting-an-Apartment-in-Seattle-BellCentre-1.jpg" },
                    { 16, true, 15, "https://www.gulleygreenhouse.com/wp-content/uploads/2021/06/cottagecore-header.jpg" },
                    { 18, true, 17, "https://gallery.streamlinevrs.com/units-gallery/00/06/CB/image_157717014.jpeg" },
                    { 20, true, 19, "https://i.pinimg.com/originals/35/15/bd/3515bd55db8db2903156e73847ce7ffa.jpg" },
                    { 21, false, 1, "https://cdn.mos.cms.futurecdn.net/dEDEQowMrHzADNHvg8LZf9.jpg" },
                    { 22, false, 1, "https://www.homeisthehamilton.com/corporate/uploads/SparkModelBedroom.jpg" },
                    { 23, false, 3, "https://blog.displate.com/wp-content/uploads/2022/08/Cottagecore-Decor-Idea_2.jpg" },
                    { 24, false, 3, "https://i.pinimg.com/736x/27/c2/99/27c299fb84d4d7ac60fb92bcf71d5961.jpg" },
                    { 25, false, 5, "https://www.ovonetwork.com/blog/wp-content/uploads/2022/07/image-26.png" },
                    { 26, false, 5, "https://cdn.homedit.com/wp-content/uploads/2017/10/Amazing-Bedroom-with-fireplace-Chalet-Trois-Couronnes-Verbier-Switzerland.jpg" },
                    { 27, false, 9, "https://static.wikia.nocookie.net/backrooms/images/5/59/Level_188_classic.jpg/revision/latest?cb=20221009201412" },
                    { 28, false, 9, "https://digital.ihg.com/is/image/ihg/holiday-inn-express-hounslow-5714832623-4x3?fmt=jpg&jpegSize=500&qlt=85&resMode=sharp2&op_usm=1.75,0.3,2.0" },
                    { 29, false, 11, "https://i0.wp.com/www.khov.com/blog/wp-content/uploads/2020/04/30993_Aspire-at-Ashley-Pointe_Ellwood_Family-Room-1024x655.jpg?resize=768%2C491&ssl=1" },
                    { 30, false, 11, "https://i.pinimg.com/474x/9c/a3/72/9ca3723d2b666577207bfa65871aeab5.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 35);
        }
    }
}
