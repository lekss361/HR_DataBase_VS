using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.DTO;
using HR_DataBase_VSDAL.Models;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using static HR_DataBase_VSBLL.Tests.Mock.MapControllerMocks;

namespace HR_DataBase_VSBLL.Tests.Requests
{
    class MapControllerTests
    {
        MappersController mappers;

        [SetUp]
        public void SetUp()
        {
            mappers = new MappersController();
        }

        [TestCaseSource(typeof(MapCommentsModelToDTO_Source))]
        public void MapCommentsModelToDTOTests(Comments comments, CommentsDTO expected)
        {
            CommentsDTO actual = mappers.MapCommentsModelToDTO(comments);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapCompaniesModelToDTO_Source))]
        public void MapCompaniesModelToDTOTests(Company company, CompaniesDTO expected)
        {
            CompaniesDTO actual = mappers.MapCompaniesModelToDTO(company);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapCompanyWithForeignKeyValueDTOToModel_Source))]
        public void MapCompanyWithForeignKeyValueDTOToModelTests(CompanyWithForeignKeyValueDTO company, CompanyWithForeignKeyValue expected)
        {
            CompanyWithForeignKeyValue actual = mappers.MapCompanyWithForeignKeyValueDTOToModel(company);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapCompaniesWithContactAndLocationDTODTOToModel_Source))]
        public void MapCompaniesWithContactAndLocationDTODTOToModel(List<CompaniesWithContactAndLocationDTO> companiesWithContactAndLocation, List<CompaniesWithContactAndLocation> expected)
        {
            List<CompaniesWithContactAndLocation> actual = mappers.MapCompaniesWithContactAndLocationDTODTOToModel(companiesWithContactAndLocation);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapCompaniesDTOToModel_Source))]
        public void MapCompaniesDTOToModel(List<CompaniesDTO> companies, List<Company> expected)
        {
            List<Company> actual = mappers.MapCompaniesDTOToModel(companies);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapContactsDTOToModel_Source))]
        public void MapContactsDTOToModel(ContactsDTO contacts, Contacts expected)
        {
            Contacts actual = mappers.MapContactsDTOToModel(contacts);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapContactsModelToDTO_Source))]
        public void MapContactsModelToDTO(Contacts contacts, ContactsDTO expected)
        {
            ContactsDTO actual = mappers.MapContactsModelToDTO(contacts);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapDirectionsModelToDTO_Source))]
        public void MapDirectionsModelToDTO(Directions directions, DirectionsDTO expected)
        {
            DirectionsDTO actual = mappers.MapDirectionsModelToDTO(directions);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapDirectionsDTOToModel_Source))]
        public void MapDirectionsDTOToModel(List<DirectionsDTO> directions, List<Directions> expected)
        {
            List<Directions> actual = mappers.MapDirectionsDTOToModel(directions);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapDivisionByCompanyDTOToModel_Source))]
        public void MapDivisionByCompanyDTOToModel(List<DivisionByCompanyDTO> divisionByCompany, List<DivisionByCompany> expected)
        {
            List<DivisionByCompany> actual = mappers.MapDivisionByCompanyDTOToModel(divisionByCompany);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapDivisionsModelToDTO_Source))]
        public void MapDivisionsModelToDTO(Divisions divisions, DivisionsDTO expected)
        {
            DivisionsDTO actual = mappers.MapDivisionsModelToDTO(divisions);
            Assert.AreEqual(expected, actual);
        }


        [TestCaseSource(typeof(MapDivisionWithForeignKeyValueDTOToModel_Source))]
        public void MapDivisionWithForeignKeyValueDTOToModel(DivisionWithForeignKeyValueDTO division, DivisionWithForeignKeyValue expected)
        {
            DivisionWithForeignKeyValue actual = mappers.MapDivisionWithForeignKeyValueDTOToModel(division);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapLocationModelToDTO_Source))]
        public void MapLocationModelToDTO(Location location, LocationDTO expected)
        {
            LocationDTO actual = mappers.MapLocationModelToDTO(location);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapLocationDTOToModel_Source))]
        public void MapLocationDTOToModel(LocationDTO location, Location expected)
        {
            Location actual = mappers.MapLocationDTOToModel(location);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapLocationDTOToModelList_Source))]
        public void MapLocationDTOToModelList(List<LocationDTO> locations, List<Location> expected)
        {
            List<Location> actual = mappers.MapLocationDTOToModel(locations);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapPositionsWithDirectionNameDTOToModel_Source))]
        public void MapPositionsWithDirectionNameDTOToModel(List<PositionsWithDirectionNameDTO> positionsWithDirectionNames, List<PositionsWithDirectionName> expected)
        {
            List<PositionsWithDirectionName> actual = mappers.MapPositionsWithDirectionNameDTOToModel(positionsWithDirectionNames);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapPreviousWorkmodelToDTO_Source))]
        public void MapPreviousWorkmodelToDTO(PreviousWork previousWork, PreviousWorkDTO expected)
        {
            PreviousWorkDTO actual = mappers.MapPreviousWorkmodelToDTO(previousWork);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapProjectModelToDTO_Source))]
        public void MapProjectModelToDTO(Project project, ProjectDTO expected)
        {
            ProjectDTO actual = mappers.MapProjectModelToDTO(project);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapProjectMapsModelsToDTO_Source))]
        public void MapProjectMapsModelsToDTO(ProjectMaps projectMaps, ProjectMapsDTO expected)
        {
            ProjectMapsDTO actual = mappers.MapProjectMapsModelsToDTO(projectMaps);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapProjectsWithDirectionNameDTOToModel_Source))]
        public void MapProjectsWithDirectionNameDTOToModel(List<ProjectsWithDirectionNameDTO> projectsWithDirectionNames, List<ProjectsWithDirectionName> expected)
        {
            List<ProjectsWithDirectionName> actual = mappers.MapProjectsWithDirectionNameDTOToModel(projectsWithDirectionNames);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapSkillNameWithTypeDTOToModel_Source))]
        public void MapSkillNameWithTypeDTOToModel(List<SkillNameWithTypeDTO> skillNameWithTypes, List<SkillNameWithType> expected)
        {
            List<SkillNameWithType> actual = mappers.MapSkillNameWithTypeDTOToModel(skillNameWithTypes);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapSkillNameWithTypeModelToDTO_Source))]
        public void MapSkillNameWithTypeModelToDTO(SkillNameWithType skillNameWithType, SkillNameWithTypeDTO expected)
        {
            SkillNameWithTypeDTO actual = mappers.MapSkillNameWithTypeModelToDTO(skillNameWithType);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapStatusesModelsToDTO_Source))]
        public void MapStatusesModelsToDTO(Statuses statuses, StatusesDTO expected)
        {
            StatusesDTO actual = mappers.MapStatusesModelsToDTO(statuses);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MapWorkersDTOToModels_Source))]
        public void MapWorkersDTOToModels(List<WorkersDTO> workers, List<Worker> expected)
        {
            List<Worker> actual = mappers.MapWorkersDTOToModels(workers);
            Assert.AreEqual(expected, actual);
        }
    }

}
