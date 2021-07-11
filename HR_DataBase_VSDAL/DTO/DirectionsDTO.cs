namespace HR_DataBase_VSDAL.Models
{
    public class DirectionsDTO
    {
        public int id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return obj is DirectionsDTO dTO &&
                   id == dTO.id &&
                   Name == dTO.Name;
        }
    }
}