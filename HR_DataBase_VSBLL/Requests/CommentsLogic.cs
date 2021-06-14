using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSBLL.Models;

namespace HR_DataBase_VSBLL.Mappers.ModelsToDTO
{
    public class CommentsLogic
    {
        private CommentsDTO commentsDTO = new CommentsDTO();
        private DapperComments dapper = new DapperComments();
        private MappersController mappersController = new MappersController();

        public CommentsDTO GetAllCommentsByWorkersID(int ID)
        {
            commentsDTO = dapper.GetAllCommentsByWorkersID(ID);
            return commentsDTO;
        }

        public void AddNewComments(Comments model)
        {
            commentsDTO = mappersController.MapCommentsModelToDTO(model);
            dapper.AddNewComments(commentsDTO);
        }
    }
}
