using HR_DataBase_VSBLL.Tests.Requests.Statuses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL.Models
{
    public class StatusesTests
    {
        private MappersController _mapper;

        [SetUp]
        public void Setup()
        {
            _mapper = new MappersController();
        }

        [TestCaseSource(typeof(MapStatusesModelsToDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListLocationModels(List<LocationDTO> actualLocationsDTO, List<CompaniesDTO> expected)
        {
            List<CompaniesDTO> actual = _mapper.MapStatusesModelsToDTO(actualLocationsDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(List<LocationDTO> locationsModel)
        {
            Assert.Throws<ArgumentNullException>(() => _mapper.MapStatusesModelsToDTO(locationsModel));
        }

=        [TestCaseSource(typeof(MapStatusesModelsToDTOSource))]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnLocationModelByID(Statuses statuses, CompaniesDTO expected)
        {
            CompaniesDTO actual = _mapper.MapStatusesModelsToDTO(statuses);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(Statuses statuses)
        {
            Assert.Throws<ArgumentNullException>(() => _mapper.MapStatusesModelsToDTO(statuses));
        }
    }
}
