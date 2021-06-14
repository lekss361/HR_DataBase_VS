using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL.Models
{
    public class DirectionsTests
    {
        private LocationMapper _locationMapper;

        [SetUp]
        public void Setup()
        {
            _locationMapper = new LocationMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListLocationModels(List<LocationDTO> actualLocationsDTO, List<CompaniesDTO> expected)
        {
            List<CompaniesDTO> actual = _locationMapper.GetModelsFromDTO(actualLocationsDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(List<LocationDTO> locationsModel)
        {
            Assert.Throws<ArgumentNullException>(() => _locationMapper.GetModelsFromDTO(locationsModel));
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed_ShouldReturnLocationDTO(CompaniesDTO locationModel, LocationDTO expected)
        {
            LocationDTO actual = _locationMapper.GetDTOFromModel(locationModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(CompaniesDTO locationModel)
        {
            Assert.Throws<ArgumentNullException>(() => _locationMapper.GetDTOFromModel(locationModel));
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnLocationModelByID(LocationDTO actualLocationDTO, CompaniesDTO expected)
        {
            CompaniesDTO actual = _locationMapper.GetModelFromDTO(actualLocationDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(LocationDTO locationDTO)
        {
            Assert.Throws<ArgumentNullException>(() => _locationMapper.GetModelFromDTO(locationDTO));
        }
    }
}
