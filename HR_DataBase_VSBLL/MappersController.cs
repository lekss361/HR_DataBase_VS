using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.DTO;
using HR_DataBase_VSDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL
{
    public class MappersController
    {
        private CompaniesDTO companiesDTO;
        private Contacts contactsModel;
        private ContactsDTO contactsDTO;
        private List<Directions> directions;
        private Location location;
        private LocationDTO locationDTO;
        private ProjectDTO projectDTO;
        private ProjectMapsDTO projectMapsDTO;
        private List<SkillNameWithType> skillNameWithTypes;
        private SkillNameWithTypeDTO skillNameWithTypeDto;
        private StatusesDTO statusesDTO;
        private List<WorkersDTO> workersDTOs;

        /// <summary>
        /// Map'им модели в DTO
        /// </summary>
        /// <param name="model"></param>
        public CommentsDTO MapModelToDTO(Comments model)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Comments, CommentsDTO>());
            Mapper mapper = new Mapper(config);
            return mapper.Map<CommentsDTO>(model);
        }

        public CompaniesDTO MapToCompaniesDTO(Company company)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Company, CompaniesDTO>());
            Mapper mapper = new Mapper(config);
            return mapper.Map<CompaniesDTO>(company);
        }

        public CompanyWithForeignKeyValue MapCompanyByIDDTOToModel(CompanyWithForeignKeyValueDTO companyByIDDTO)
        {
            CompanyWithForeignKeyValue sda = new CompanyWithForeignKeyValue();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<CompanyWithForeignKeyValueDTO, CompanyWithForeignKeyValue>());

            Mapper mapper = new Mapper(config);

            sda = mapper.Map<CompanyWithForeignKeyValue>(companyByIDDTO);
            return sda;
        }

        public List<CompaniesWithContactAndLocation> MapCompaniesDTOToModelListFull(List<CompaniesWithContactAndLocationDTO> companiesWithContactAndLocationDTO)
        {
            List<CompaniesWithContactAndLocation> companies = new List<CompaniesWithContactAndLocation>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<CompaniesWithContactAndLocationDTO,
                CompaniesWithContactAndLocation>());

            Mapper mapper = new Mapper(config);
            companies = mapper.Map<List<CompaniesWithContactAndLocation>>(companiesWithContactAndLocationDTO);
            return companies;
        }

        public List<Company> MapCompaniesDTOToModelList(List<CompaniesDTO> companiesDTO)
        {
            List<Company> companies = new List<Company>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<CompaniesDTO, Company>()
                .ForMember(dest => dest.Id, option => option.MapFrom(source => source.Id))
                .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name))
                .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information))
                .ForMember(dest => dest.ContactID, option => option.MapFrom(source => source.ContactID))
                .ForMember(dest => dest.LocationID, option => option.MapFrom(source => source.LocationID)));

            Mapper mapper = new Mapper(config);

            companies = mapper.Map<List<Company>>(companiesDTO);
            return companies;
        }

        public CompaniesDTO MapModelToCompaniesDTO(Company companies)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Company, CompaniesDTO>()
            .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name))
            .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information))
            .ForMember(dest => dest.ContactID, option => option.MapFrom(source => source.ContactID))
            .ForMember(dest => dest.LocationID, option => option.MapFrom(source => source.LocationID)));

            Mapper mapper = new Mapper(config);

            companiesDTO = mapper.Map<CompaniesDTO>(companies);
            return companiesDTO;
        }
        public List<Contacts> MapListDTOToListModel(List<ContactsDTO> ContactsDTO)
        {
            List<Contacts> tmp = new List<Contacts>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<LocationDTO, Location>()
                .ForMember(dest => dest.LocationIndex, option => option.MapFrom(source => source.LocationIndex))
                .ForMember(dest => dest.Country, option => option.MapFrom(source => source.Country))
                .ForMember(dest => dest.City, option => option.MapFrom(source => source.City))
                .ForMember(dest => dest.Street, option => option.MapFrom(source => source.Street))
                .ForMember(dest => dest.HouseNumber, option => option.MapFrom(source => source.HouseNumber))
                .ForMember(dest => dest.ApartmentNumber, option => option.MapFrom(source => source.ApartmentNumber)));

            Mapper mapper = new Mapper(config);

            tmp = mapper.Map<List<Contacts>>(ContactsDTO);
            return tmp;
        }

        public Contacts MapDTOToModel(ContactsDTO contactsDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ContactsDTO, Contacts>()
            .ForMember(dest => dest.id, option => option.MapFrom(source => source.id))
            .ForMember(dest => dest.Phone, option => option.MapFrom(source => source.Phone))
            .ForMember(dest => dest.Email, option => option.MapFrom(source => source.Email))
            .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information)));

            Mapper mapper = new Mapper(config);

            contactsModel = mapper.Map<Contacts>(contactsDTO);
            return contactsModel;
        }

        public ContactsDTO MapModelToDTO(Contacts modelContacts)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Contacts, ContactsDTO>()
            .ForMember(dest => dest.Phone, option => option.MapFrom(source => source.Phone))
            .ForMember(dest => dest.Email, option => option.MapFrom(source => source.Email))
            .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information)));

            Mapper mapper = new Mapper(config);

            contactsDTO = mapper.Map<ContactsDTO>(modelContacts);
            return contactsDTO;
        }

        public DirectionsDTO MapToDirectionsDTO(Directions directions)
        {
            DirectionsDTO directionsDTO = new DirectionsDTO();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Directions, DirectionsDTO>()
                .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name)));
            Mapper mapper = new Mapper(config);

            directionsDTO = mapper.Map<DirectionsDTO>(directions);
            return directionsDTO;
        }
        public List<Directions> MapToDirectionsModel(List<DirectionsDTO> directionsDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<DirectionsDTO, Directions>());
            Mapper mapper = new Mapper(config);

            directions = mapper.Map<List<Directions>>(directionsDTO);
            return directions;
        }

        public List<DivisionByCompany> MapDivisionByCompanyDTOToModelList(List<DivisionByCompanyDTO> divisionByCompanyDTODtos)
        {
            List<DivisionByCompany> sda = new List<DivisionByCompany>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<DivisionByCompanyDTO, DivisionByCompany>()
                .ForMember(dest => dest.id, option => option.MapFrom(source => source.id))
                .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name))
                .ForMember(dest => dest.DirectionName, option => option.MapFrom(source => source.DirectionName))
                .ForMember(dest => dest.Phone, option => option.MapFrom(source => source.Phone))
                .ForMember(dest => dest.Email, option => option.MapFrom(source => source.Email))
                .ForMember(dest => dest.Country, option => option.MapFrom(source => source.Country))
                .ForMember(dest => dest.City, option => option.MapFrom(source => source.City)));

            Mapper mapper = new Mapper(config);

            sda = mapper.Map<List<DivisionByCompany>>(divisionByCompanyDTODtos);
            return sda;
        }

        public DivisionsDTO MapToDivisionsDTO(Divisions divisions)
        {
            DivisionsDTO divisionsDTO = new DivisionsDTO();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Divisions, DivisionsDTO>()

            .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name))
            .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information))
            .ForMember(dest => dest.CompanyID, option => option.MapFrom(source => source.CompanyID))
            .ForMember(dest => dest.ContactID, option => option.MapFrom(source => source.ContactID))
            .ForMember(dest => dest.LocationID, option => option.MapFrom(source => source.LocationID))
            .ForMember(dest => dest.DirectionsID, option => option.MapFrom(source => source.DirectionsID)));

            Mapper mapper = new Mapper(config);

            divisionsDTO = mapper.Map<DivisionsDTO>(divisions);

            return divisionsDTO;
        }

        public DivisionWithForeignKeyValue MapDivisionByIDDTOToModel(DivisionWithForeignKeyValueDTO divisionByIDDTO)
        {
            DivisionWithForeignKeyValue sda = new DivisionWithForeignKeyValue();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<DivisionWithForeignKeyValueDTO, DivisionWithForeignKeyValue>()
                .ForMember(dest => dest.CompanyID, option => option.MapFrom(source => source.CompanyID))
                .ForMember(dest => dest.DirectionId, option => option.MapFrom(source => source.DirectionId))
                .ForMember(dest => dest.ContactID, option => option.MapFrom(source => source.ContactID))
                .ForMember(dest => dest.LocationID, option => option.MapFrom(source => source.LocationID))
                .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name))
                .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information))
                .ForMember(dest => dest.CompanyName, option => option.MapFrom(source => source.CompanyName))
                .ForMember(dest => dest.DirectionName, option => option.MapFrom(source => source.DirectionName))
                .ForMember(dest => dest.Phone, option => option.MapFrom(source => source.Phone))
                .ForMember(dest => dest.Email, option => option.MapFrom(source => source.Email))
                .ForMember(dest => dest.ContactInformation, option => option.MapFrom(source => source.ContactInformation))
                .ForMember(dest => dest.Country, option => option.MapFrom(source => source.Country))
                .ForMember(dest => dest.City, option => option.MapFrom(source => source.City))
                .ForMember(dest => dest.Street, option => option.MapFrom(source => source.Email))
                .ForMember(dest => dest.ApartmentNumber, option => option.MapFrom(source => source.ApartmentNumber))
                .ForMember(dest => dest.HouseNumber, option => option.MapFrom(source => source.HouseNumber))
                .ForMember(dest => dest.LocationIndex, option => option.MapFrom(source => source.LocationIndex)));

            Mapper mapper = new Mapper(config);

            sda = mapper.Map<DivisionWithForeignKeyValue>(divisionByIDDTO);
            return sda;
        }

        public LocationDTO MapModelToLocationDTO(Location location)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Location, LocationDTO>()
            .ForMember(dest => dest.LocationIndex, option => option.MapFrom(source => source.LocationIndex))
            .ForMember(dest => dest.Country, option => option.MapFrom(source => source.Country))
            .ForMember(dest => dest.City, option => option.MapFrom(source => source.City))
            .ForMember(dest => dest.Street, option => option.MapFrom(source => source.Street))
            .ForMember(dest => dest.HouseNumber, option => option.MapFrom(source => source.HouseNumber))
            .ForMember(dest => dest.ApartmentNumber, option => option.MapFrom(source => source.ApartmentNumber)));

            Mapper mapper = new Mapper(config);

            locationDTO = mapper.Map<LocationDTO>(location);
            return locationDTO;
        }

        public Location MapLocationDTOToModel(LocationDTO locationDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LocationDTO, Location>()
                .ForMember(dest => dest.LocationIndex, option => option.MapFrom(source => source.LocationIndex))
                .ForMember(dest => dest.id, option => option.MapFrom(source => source.id))
                .ForMember(dest => dest.Country, option => option.MapFrom(source => source.Country))
                .ForMember(dest => dest.City, option => option.MapFrom(source => source.City))
                .ForMember(dest => dest.Street, option => option.MapFrom(source => source.Street))
                .ForMember(dest => dest.HouseNumber, option => option.MapFrom(source => source.HouseNumber))
                .ForMember(dest => dest.ApartmentNumber, option => option.MapFrom(source => source.ApartmentNumber)));

            Mapper mapper = new Mapper(config);

            location = mapper.Map<Location>(locationDTO);
            return location;
        }

        public List<Location> MapLocationDTOToModelList(List<LocationDTO> locationDtos)
        {
            List<Location> tmp = new List<Location>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<LocationDTO, Location>()
                .ForMember(dest => dest.LocationIndex, option => option.MapFrom(source => source.LocationIndex))
                .ForMember(dest => dest.Country, option => option.MapFrom(source => source.Country))
                .ForMember(dest => dest.City, option => option.MapFrom(source => source.City))
                .ForMember(dest => dest.Street, option => option.MapFrom(source => source.Street))
                .ForMember(dest => dest.HouseNumber, option => option.MapFrom(source => source.HouseNumber))
                .ForMember(dest => dest.ApartmentNumber, option => option.MapFrom(source => source.ApartmentNumber)));

            Mapper mapper = new Mapper(config);

            tmp = mapper.Map<List<Location>>(locationDtos);
            return tmp;
        }

        public List<PositionsWithDirectionName> MapPositionsWithDirectionNameDTOToModelList(List<PositionsWithDirectionNameDTO> positionsWithDirectionNameDTODtos)
        {
            List<PositionsWithDirectionName> sda = new List<PositionsWithDirectionName>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<PositionsWithDirectionNameDTO, PositionsWithDirectionName>()
                .ForMember(dest => dest.id, option => option.MapFrom(source => source.id))
                .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name))
                .ForMember(dest => dest.DirectionName, option => option.MapFrom(source => source.DirectionName)));

            Mapper mapper = new Mapper(config);

            sda = mapper.Map<List<PositionsWithDirectionName>>(positionsWithDirectionNameDTODtos);
            return sda;
        }

        public PreviousWorkDTO MapToPreviousWorkDTO(PreviousWork previousJob)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PreviousWork, PreviousWorkDTO>()
                .ForMember(dest => dest.WorkerID, option => option.MapFrom(source => source.WorkerID))
                .ForMember(dest => dest.StartDate, option => option.MapFrom(source => source.StartDate))
                .ForMember(dest => dest.EndDate, option => option.MapFrom(source => source.EndDate))
                .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information))
            );

            Mapper mapper = new Mapper(config);
            return mapper.Map<PreviousWorkDTO>(previousJob);
        }
        public ProjectDTO MapModelToDTO(Project model)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectDTO>()
            .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name))
            .ForMember(dest => dest.DirectionsID, option => option.MapFrom(source => source.DirectionsID))
            .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information)));

            Mapper mapper = new Mapper(config);

            projectDTO = mapper.Map<ProjectDTO>(model);
            return projectDTO;
        }

        public ProjectMapsDTO MapToDirectionsDTO(ProjectMaps projectMaps)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProjectMaps, ProjectMapsDTO>());
            Mapper mapper = new Mapper(config);
            projectMapsDTO = mapper.Map<ProjectMapsDTO>(projectMaps);
            return projectMapsDTO;
        }

        public List<ProjectsWithDirectionName> MapProjectsWithDirectionNameDTOToModelList(List<ProjectsWithDirectionNameDTO> projectsWithDirectionNameDTODtos)
        {
            List<ProjectsWithDirectionName> sda = new List<ProjectsWithDirectionName>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProjectsWithDirectionNameDTO, ProjectsWithDirectionName>()
                .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name))
                .ForMember(dest => dest.id, option => option.MapFrom(source => source.id))
                .ForMember(dest => dest.DirectionName, option => option.MapFrom(source => source.DirectionName))
                .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information)));

            Mapper mapper = new Mapper(config);

            sda = mapper.Map<List<ProjectsWithDirectionName>>(projectsWithDirectionNameDTODtos);
            return sda;
        }

        public List<SkillNameWithType> MapSkillNameByIdDTOToModelList(List<SkillNameWithTypeDTO> skillNameByIdDtos)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<SkillNameWithTypeDTO, SkillNameWithType>());
            Mapper mapper = new Mapper(config);
            skillNameWithTypes = mapper.Map<List<SkillNameWithType>>(skillNameByIdDtos);
            return skillNameWithTypes;
        }

        public SkillNameWithTypeDTO MapToSkillNameDTO(SkillNameWithType skillName)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<SkillNameWithType, SkillNameWithTypeDTO>());
            Mapper mapper = new Mapper(config);
            skillNameWithTypeDto = mapper.Map<SkillNameWithTypeDTO>(skillName);
            return skillNameWithTypeDto;
        }

        public StatusesDTO MapToStatusesDTO(Statuses statuses)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Statuses, StatusesDTO>()
            .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name)));

            Mapper mapper = new Mapper(config);

            statusesDTO = mapper.Map<StatusesDTO>(statuses);
            return statusesDTO;
        }

        public WorkersDTO MapToWorkersDTO(Worker worker)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Worker, WorkersDTO>());

            Mapper mapper = new Mapper(config);

            return mapper.Map<WorkersDTO>(worker);
        }

        public WorkersDTO MapWorkerModelToWorkerDTO(Worker worker)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Worker, WorkersDTO>());

            Mapper mapper = new Mapper(config);

            return mapper.Map<WorkersDTO>(worker);
        }

        public List<Worker> MapListWorkersDTOToListWorkers(List<WorkersDTO> workers)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<WorkersDTO, Worker>());
            Mapper mapper = new Mapper(config);
            return mapper.Map<List<Worker>>(workers);
        }
    }
}
