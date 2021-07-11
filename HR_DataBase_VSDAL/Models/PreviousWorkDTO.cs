namespace HR_DataBase_VSDAL.DTO
{
    public class PreviousWorkDTO
    {
        public int WorkerID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Information { get; set; }

        public override bool Equals(object obj)
        {
            return obj is PreviousWorkDTO dTO &&
                   WorkerID == dTO.WorkerID &&
                   StartDate == dTO.StartDate &&
                   EndDate == dTO.EndDate &&
                   Information == dTO.Information;
        }
    }
}