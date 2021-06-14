using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.DTO;
using HR_DataBase_VSDAL.Models;
using System.Collections.Generic;

namespace HR_DataBase_VSBLL
{
    public class MappersController
    {
        public CommentsDTO MapCommentsModelToDTO(Comments comments)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<Comments, CommentsDTO>()));
            return mapper.Map<CommentsDTO>(comments);
        }

        public CompaniesDTO MapCompaniesModelToDTO(Company company)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<Company, CompaniesDTO>()));
            return mapper.Map<CompaniesDTO>(company);
        }

        public CompanyWithForeignKeyValue MapCompanyWithForeignKeyValueDTOToModel(CompanyWithForeignKeyValueDTO company)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<CompanyWithForeignKeyValueDTO, CompanyWithForeignKeyValue>()));
            return mapper.Map<CompanyWithForeignKeyValue>(company);
        }

        public List<CompaniesWithContactAndLocation> MapCompaniesWithContactAndLocationDTODTOToModel(List<CompaniesWithContactAndLocationDTO> companiesWithContactAndLocationDTO)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<CompaniesWithContactAndLocationDTO, CompaniesWithContactAndLocation>()));
            return mapper.Map<List<CompaniesWithContactAndLocation>>(companiesWithContactAndLocationDTO);
        }

        public List<Company> MapCompaniesDTOToModel(List<CompaniesDTO> companies)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<CompaniesDTO, Company>()));
            return mapper.Map<List<Company>>(companies);
        }

        public Contacts MapContactsDTOToModel(ContactsDTO contacts)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<ContactsDTO, Contacts>()));
            return mapper.Map<Contacts>(contacts);
        }

        public ContactsDTO MapContactsModelToDTO(Contacts contacts)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<Contacts, ContactsDTO>()));
            return mapper.Map<ContactsDTO>(contacts);
        }

        public DirectionsDTO MapDirectionsModelToDTO(Directions directions)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<Directions, DirectionsDTO>()));
            return mapper.Map<DirectionsDTO>(directions);
        }
        public List<Directions> MapDirectionsDTOToModel(List<DirectionsDTO> directions)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<DirectionsDTO, Directions>()));
            return mapper.Map<List<Directions>>(directions);
        }

        public List<DivisionByCompany> MapDivisionByCompanyDTOToModel(List<DivisionByCompanyDTO> divisionByCompany)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<DivisionByCompanyDTO, DivisionByCompany>()));
            return mapper.Map<List<DivisionByCompany>>(divisionByCompany);
        }

        public DivisionsDTO MapDivisionsModelToDTO(Divisions divisions)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<Divisions, DivisionsDTO>()));
            return mapper.Map<DivisionsDTO>(divisions);
        }

        public DivisionWithForeignKeyValue MapDivisionWithForeignKeyValueDTOToModel(DivisionWithForeignKeyValueDTO division)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<DivisionWithForeignKeyValueDTO, DivisionWithForeignKeyValue>()));
            return mapper.Map<DivisionWithForeignKeyValue>(division);
        }

        public LocationDTO MapLocationModelToDTO(Location location)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<Location, LocationDTO>()));
            return mapper.Map<LocationDTO>(location);
        }

        public Location MapLocationDTOToModel(LocationDTO location)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<LocationDTO, Location>()));
            return mapper.Map<Location>(location);
        }

        public List<Location> MapLocationDTOToModel(List<LocationDTO> locations)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<LocationDTO, Location>()));
            return mapper.Map<List<Location>>(locations);
        }

        public List<PositionsWithDirectionName> MapPositionsWithDirectionNameDTOToModel(List<PositionsWithDirectionNameDTO> positionsWithDirectionNames)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<PositionsWithDirectionNameDTO, PositionsWithDirectionName>()));
            return mapper.Map<List<PositionsWithDirectionName>>(positionsWithDirectionNames);
        }

        public PreviousWorkDTO MapPreviousWorkmodelToDTO(PreviousWork previousWork)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<PreviousWork, PreviousWorkDTO>()));
            return mapper.Map<PreviousWorkDTO>(previousWork);
        }
        public ProjectDTO MapProjectModelToDTO(Project project)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<Project, ProjectDTO>()));
            return mapper.Map<ProjectDTO>(project);
        }

        public ProjectMapsDTO MapProjectMapsModelsToDTO(ProjectMaps projectMaps)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<ProjectMaps, ProjectMapsDTO>()));
            return mapper.Map<ProjectMapsDTO>(projectMaps);
        }

        public List<ProjectsWithDirectionName> MapProjectsWithDirectionNameDTOToModel(List<ProjectsWithDirectionNameDTO> projectsWithDirectionNames)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<ProjectsWithDirectionNameDTO, ProjectsWithDirectionName>()));
            return mapper.Map<List<ProjectsWithDirectionName>>(projectsWithDirectionNames);
        }

        public List<SkillNameWithType> MapSkillNameWithTypeDTOToModel(List<SkillNameWithTypeDTO> skillNameWithTypes)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<SkillNameWithTypeDTO, SkillNameWithType>()));
            return mapper.Map<List<SkillNameWithType>>(skillNameWithTypes);
        }

        public SkillNameWithTypeDTO MapSkillNameWithTypeModelToDTO(SkillNameWithType skillNameWithType)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<SkillNameWithType, SkillNameWithTypeDTO>()));
            return mapper.Map<SkillNameWithTypeDTO>(skillNameWithType);
        }

        public StatusesDTO MapStatusesModelsToDTO(Statuses statuses)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<Statuses, StatusesDTO>()));
            return mapper.Map<StatusesDTO>(statuses);
        }

        public WorkersDTO MapWorkerModelToDTO(Worker worker)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<Worker, WorkersDTO>()));
            return mapper.Map<WorkersDTO>(worker);
        }

        public List<Worker> MapWorkersDTOToModels(List<WorkersDTO> workers)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<WorkersDTO, Worker>()));
            return mapper.Map<List<Worker>>(workers);
        }

        public WorkerWithForeignKeyValue MapWorkerWithForeignKeyValueDTOToModel(WorkerWithForeignKeyValueDTO division)
        {
            Mapper mapper = new Mapper(new MapperConfiguration(
                cfg => cfg.CreateMap<WorkerWithForeignKeyValueDTO, WorkerWithForeignKeyValue>()));
            return mapper.Map<WorkerWithForeignKeyValue>(division);
        }
    }
}
