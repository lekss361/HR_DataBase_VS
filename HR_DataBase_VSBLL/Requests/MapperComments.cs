using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSBLL.Models;
using AutoMapper;

namespace HR_DataBase_VSBLL.Mappers.ModelsToDTO
{
    public class MapperComments
    {
        CommentsDTO commentsDTO = new CommentsDTO();
        DapperComments dapper = new DapperComments();

        /// <summary>
        /// поиск данных по ID
        /// </summary>
        /// <param name="ID">ID записи</param>
        /// <returns>DTO записи из БД</returns>
        public CommentsDTO GetAllCommentsByWorkersID(int ID)
        {
            commentsDTO = dapper.GetAllCommentsByWorkersID(ID);
            return commentsDTO;
        }

        /// <summary>
        /// Добавляем новую запись в БД
        /// </summary>
        /// <param name="model">Модель</param>
        public void AddNewComments(Comments model)
        {
            commentsDTO = MapModelToDTO(model);
            dapper.AddNewComments(commentsDTO);
        }

        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="model"></param>
        private CommentsDTO MapModelToDTO(Comments model)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Comments, CommentsDTO>()
            .ForMember(dest => dest.WorkersID, option => option.MapFrom(source => source.WorkersID))
            .ForMember(dest => dest.Comment, option => option.MapFrom(source => source.Comment))
            .ForMember(dest => dest.Date, option => option.MapFrom(source => source.Date)));

            Mapper mapper = new Mapper(config);

            commentsDTO = mapper.Map<CommentsDTO>(model);
            return commentsDTO;
        }
    }
}
