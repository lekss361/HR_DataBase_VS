namespace HR_DataBase_VSBLL.Models
{
    public class ProjectMaps
    {
        public int WorkerID { get; set; }
        public int ProjectID { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ProjectMaps maps &&
                   WorkerID == maps.WorkerID &&
                   ProjectID == maps.ProjectID;
        }
    }
}