using System.Collections.Generic;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSDAL.Models;

namespace HR_DataBase_VSBLL.Mappers
{
    public class WorkerLogic
    {
        WorkersDTO workersDTO = new WorkersDTO();
        List<WorkersDTO> listWorkersDTOs = new List<WorkersDTO>();
        private List<Worker> listWorkers;
        DapperWorker dapper = new DapperWorker();
        MappersController mappersController = new MappersController();

        public int AddNewWorker(Worker worker)
        {
            workersDTO = mappersController.MapToWorkersDTO(worker);
            return dapper.AddNewWorker(workersDTO);
        }

        public List<Worker> SearchWorkersBySameParams(Worker worker)
        {
            workersDTO = mappersController.MapWorkerModelToWorkerDTO(worker);
            listWorkersDTOs = dapper.SearchWorkerBySameParam(workersDTO);
            listWorkers = mappersController.MapListWorkersDTOToListWorkers(listWorkersDTOs);
            return listWorkers;
        }
    }
}
