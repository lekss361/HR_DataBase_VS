using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL.Models
{
    public class WorkerTests
    {
        private MappersController _MappersController;

        [SetUp]
        public void Setup()
        {
            _MappersController = new MappersController();
        }

        [TestCaseSource(typeof(GetModelsFromDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListLocationModels(Comments comments, List<StatusesDTO> expected)
        {
            Comments actual = _MappersController.GetModelsFromDTO(comments);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(List<LocationDTO> locationsModel)
        {
            Assert.Throws<ArgumentNullException>(() => _MappersController.GetModelsFromDTO(locationsModel));
        }

        [TestCaseSource(typeof(GetDTOFromModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed_ShouldReturnLocationDTO(StatusesDTO locationModel, LocationDTO expected)
        {
            LocationDTO actual = _MappersController.GetDTOFromModel(locationModel);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(StatusesDTO locationModel)
        {
            Assert.Throws<ArgumentNullException>(() => _MappersController.GetDTOFromModel(locationModel));
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnLocationModelByID(LocationDTO actualLocationDTO, StatusesDTO expected)
        {
            StatusesDTO actual = _MappersController.GetModelFromDTO(actualLocationDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(LocationDTO locationDTO)
        {
            Assert.Throws<ArgumentNullException>(() => _MappersController.GetModelFromDTO(locationDTO));
        }
    }
}
