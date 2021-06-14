using System.Collections.Generic;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSDAL.Models;

namespace HR_DataBase_VSBLL.Mappers
{
    public class WorkerLogic
    {
        private WorkersDTO workersDTO = new WorkersDTO();
        private List<WorkersDTO> listWorkersDTOs = new List<WorkersDTO>();
        private DapperWorker dapper = new DapperWorker();
        private MappersController mappersController = new MappersController();

        public int AddNewWorker(Worker worker)
        {
            workersDTO = mappersController.MapWorkerModelToDTO(worker);
            return dapper.AddNewWorker(workersDTO);
        }

        public List<Worker> SearchWorkersBySameParams(Worker worker)
        {
            workersDTO = mappersController.MapWorkerModelToDTO(worker);
            listWorkersDTOs = dapper.SearchWorkerBySameParam(workersDTO);
            return mappersController.MapWorkersDTOToModels(listWorkersDTOs);
        }
    }
}
