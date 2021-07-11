namespace HR_DataBase_VSDAL.Models
{
   public class ProjectsWithDirectionNameDTO
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string DirectionName { get; set; }
        public string Information { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ProjectsWithDirectionNameDTO dTO &&
                   id == dTO.id &&
                   Name == dTO.Name &&
                   DirectionName == dTO.DirectionName &&
                   Information == dTO.Information;
        }
    }
}