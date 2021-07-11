namespace HR_DataBase_VSBLL.Models
{
    public class Project
    {
        public string Name { get; set; }
        public int DirectionsID { get; set; }
        public string Information { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Project project &&
                   Name == project.Name &&
                   DirectionsID == project.DirectionsID &&
                   Information == project.Information;
        }
    }
}