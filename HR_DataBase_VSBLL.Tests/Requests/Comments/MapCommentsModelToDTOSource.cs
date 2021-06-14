using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_DataBase_VSBLL;

namespace HR_DataBase_VSBLL.Tests.Requests.Comments
{
    class MapCommentsModelToDTOSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
                        {
                new Comments()
                {
                    CommentID = 1,
                    Comment=1,
                    Date = 1,
                },
                new Comments()
                {
                    CommentID = 1,
                    Comment=1,
                    Date = 1,
                },
                new Comments()
                {
                    CommentID = 1,
                    Comment=1,
                    Date = 1,
                },
                
                        };
            yield return new object[]
            {
                2,
                new LocationDTO()
                {
                    ID = 2,
                    CityID=2,
                    ApartmentNumber = 13,
                    Street = "Pushkina",
                    Block = "vtoroy",
                    HouseNumber = 15,
                    PostIndex = 25000
                },
                new CityDTO()
                {
                    ID = 2,
                    Name = "Moscow",
                    CountryID = 2
                },
                new CountryDTO()
                {
                    ID = 2,
                    Name = "Russia"
                },
                new Models.Adress()
                {
                    ID = 2,
                    CityID=2,
                    ApartmentNumber = 13,
                    Street = "Pushkina",
                    Block = "vtoroy",
                    HourseNumber = 15,
                    PostIndex = 25000,
                    City = new CityModel()
                    {
                        ID = 2,
                        Name = "Moscow",
                        CountryID = 2
                    },
                    Country = new CountryModel()
                    {
                        ID = 2,
                        Name = "Russia"
                    }
                }
            };
        }
    }
}
