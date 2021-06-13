using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSDAL.Models;

namespace HR_DataBase_VSBLL.Mappers
{
    public class MapperWorker
    {
        int Id;

        WorkersDTO workersDTO = new WorkersDTO();
        List<WorkersDTO> workersDTOs = new List<WorkersDTO>();
        List<Worker> workers = new List<Worker>();

        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="worker"></param>
        public int MapToWorkersDTO(Worker worker)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Worker, WorkersDTO>());

            Mapper mapper = new Mapper(config);
            DapperWorker dapper = new DapperWorker();

            workersDTO = mapper.Map<WorkersDTO>(worker);
            Id=dapper.AddNewWorker(workersDTO);
            return Id;
        }

        public List<Worker> SearchWorkersBySameParams(Worker worker)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Worker, WorkersDTO>());
            var configListDTOToListModel = new MapperConfiguration(cfg => cfg.CreateMap<List<WorkersDTO>, List<Worker>>());
           
            Mapper mapper = new Mapper(config);
            Mapper mapperList = new Mapper(configListDTOToListModel);
            DapperWorker dapper = new DapperWorker();
            workersDTOs =  dapper.SearchWorkerBySameParam(mapper.Map<WorkersDTO>(worker));
            return mapperList.Map<List<Worker>>(workersDTOs);
        }
    }
}
