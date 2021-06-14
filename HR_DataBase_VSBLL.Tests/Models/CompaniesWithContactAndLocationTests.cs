using HR_DataBase_VSBLL.Tests.Requests.Comments;
using HR_DataBase_VSBLL.Tests.Requests.Company;
using HR_DataBase_VSDAL.DTO;
using HR_DataBase_VSDAL.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL.Models
{
    public class CompaniesWithContactAndLocationTests
    {
        private MappersController _mapper;

        [SetUp]
        public void Setup()
        {
            _mapper = new MappersController();
        }

        [TestCaseSource(typeof(MapCompaniesModelToDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListLocationModels(Company company, HR_DataBase_VSDAL.Models.CompaniesDTO expected)
        {
            HR_DataBase_VSDAL.Models.CompaniesDTO actual = _mapper.MapCompaniesModelToDTO(company);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(Company company)
        {
            Assert.Throws<ArgumentNullException>(() => _mapper.MapCompaniesModelToDTO(company));
        }

        [TestCaseSource(typeof(MapCompaniesWithContactAndLocationDTODTOToModelSource))]
        public void GetDTOFromModel_WhenValidTestPassed_ShouldReturnLocationDTO(CompaniesDTO company, Company expected)
        {
            Company actual = _mapper.MapCompanyWithForeignKeyValueDTOToModel(company);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(CompaniesDTO locationModel)
        {
            Assert.Throws<ArgumentNullException>(() => _mapper.MapCompaniesWithContactAndLocationDTODTOToModel(locationModel));
        }

        [TestCaseSource(typeof(GetModelFromDTOSource))]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnLocationModelByID(Company actualLocationDTO, CompaniesDTO expected)
        {
            CompaniesDTO actual = _mapper.GetModelFromDTO(actualLocationDTO);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(Company locationDTO)
        {
            Assert.Throws<ArgumentNullException>(() => _mapper.GetModelFromDTO(locationDTO));
        }
    }
}
