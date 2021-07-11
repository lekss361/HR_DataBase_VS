namespace HR_DataBase_VSBLL.Models
{
    public class Comments
    {
        public int WorkersID { get; set; }
        public string Comment { get; set; }
        public string Date { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Comments model &&
                   WorkersID == model.WorkersID &&
                   Comment == model.Comment &&
                   Date == model.Date;
        }
    }
}