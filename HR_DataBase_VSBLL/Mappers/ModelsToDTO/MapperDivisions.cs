using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;

namespace HR_DataBase_VSBLL.Mappers
{
    public class MapperDivisions
    {
        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="divisions"></param>
        /// 
        DivisionWithForeignKeyValueDTO divisionWithForeignKeyValueDTO = new DivisionWithForeignKeyValueDTO();
        DivisionWithForeignKeyValue divisionWithForeignKeyValue = new DivisionWithForeignKeyValue();
        DivisionsDTO divisionsDTO = new DivisionsDTO();
        DapperDivision dapper = new DapperDivision();

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
            DapperDivision dapper = new DapperDivision();

            divisionsDTO = mapper.Map<DivisionsDTO>(divisions);
           
            return divisionsDTO;
        }

        public int UpdateDivisionByid(Divisions model, int id)
        {
            divisionsDTO = MapToDivisionsDTO(model);
            id = dapper.UpdateDivisoonsById(divisionsDTO, id);
            return id;
        }



        public DivisionWithForeignKeyValue GetDivisionByID(int id)
        {
            divisionWithForeignKeyValueDTO = dapper.GetDivisionByID(id);
            divisionWithForeignKeyValue  = MapDivisionByIDDTOToModel(divisionWithForeignKeyValueDTO);
            

            return divisionWithForeignKeyValue;
        }



        private DivisionWithForeignKeyValue MapDivisionByIDDTOToModel(DivisionWithForeignKeyValueDTO divisionByIDDTO)
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
    }
}
