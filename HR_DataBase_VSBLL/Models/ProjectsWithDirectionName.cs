namespace HR_DataBase_VSBLL.Models
{
   public class ProjectsWithDirectionName
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string DirectionName { get; set; }
        public string Information { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ProjectsWithDirectionName name &&
                   id == name.id &&
                   Name == name.Name &&
                   DirectionName == name.DirectionName &&
                   Information == name.Information;
        }
    }
}