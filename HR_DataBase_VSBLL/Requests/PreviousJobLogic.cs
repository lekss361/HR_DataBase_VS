using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSDAL.DTO;

namespace HR_DataBase_VSBLL.Mappers.ModelsToDTO
{
    public class PreviousJobLogic
    {
        private MappersController mappersController = new MappersController();
        private PreviousWorkDapper dapper = new PreviousWorkDapper();
        private PreviousWorkDTO previousJobDTO = new PreviousWorkDTO();

        public void AddPreviousWork(PreviousWork previousJob)
        {
            previousJobDTO = mappersController.MapPreviousWorkmodelToDTO(previousJob);
            dapper.AddPreviousWork(previousJobDTO);
        }
    }
}