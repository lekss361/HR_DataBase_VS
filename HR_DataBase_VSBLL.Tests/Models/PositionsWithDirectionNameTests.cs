using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL.Models
{
    public class PositionsWithDirectionNameTests
    {
        private LocationMapper _locationMapper;

        [SetUp]
        public void Setup()
        {
            _locationMapper = new LocationMapper();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListLocationModels(List<LocationDTO> actualLocationsDTO, List<StatusesDTO> expected)
        {
            List<StatusesDTO> actual = _locationMapper.GetModelsFromDTO(actualLocationsDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(List<LocationDTO> locationsModel)
        {
            Assert.Throws<ArgumentNullException>(() => _locationMapper.GetModelsFromDTO(locationsModel));
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed_ShouldReturnLocationDTO(StatusesDTO locationModel, LocationDTO expected)
        {
            LocationDTO actual = _locationMapper.GetDTOFromModel(locationModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(StatusesDTO locationModel)
        {
            Assert.Throws<ArgumentNullException>(() => _locationMapper.GetDTOFromModel(locationModel));
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnLocationModelByID(LocationDTO actualLocationDTO, StatusesDTO expected)
        {
            StatusesDTO actual = _locationMapper.GetModelFromDTO(actualLocationDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(LocationDTO locationDTO)
        {
            Assert.Throws<ArgumentNullException>(() => _locationMapper.GetModelFromDTO(locationDTO));
        }
    }
}
