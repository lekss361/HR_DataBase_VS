namespace HR_DataBase_VSDAL.Models
{
    public class CommentsDTO
    {
        public int WorkersID { get; set; }
        public string Comment { get; set; }
        public string Date { get; set; }

        public override bool Equals(object obj)
        {
            return obj is CommentsDTO model &&
                   WorkersID == model.WorkersID &&
                   Comment == model.Comment &&
                   Date == model.Date;
        }
    }
}