using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSBLL.Models;

namespace HR_DataBase_VSBLL.Mappers.ModelsToDTO
{
    public class CommentsLogic
    {
        CommentsDTO commentsDTO = new CommentsDTO();
        DapperComments dapper = new DapperComments();
        MappersController mappersController = new MappersController();

        /// <summary>
        /// Поиск данных по ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public CommentsDTO GetAllCommentsByWorkersID(int ID)
        {
            commentsDTO = dapper.GetAllCommentsByWorkersID(ID);
            return commentsDTO;
        }

        /// <summary>
        /// Добавляем новую запись в БД
        /// </summary>
        /// <param name="model"></param>
        public void AddNewComments(Comments model)
        {
            commentsDTO = mappersController.MapModelToDTO(model);
            dapper.AddNewComments(commentsDTO);
        }
    }
}
