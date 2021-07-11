namespace HR_DataBase_VSDAL.DTO
{
    public class PositionsWithDirectionNameDTO
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string DirectionName { get; set; }

        public override bool Equals(object obj)
        {
            return obj is PositionsWithDirectionNameDTO dTO &&
                   id == dTO.id &&
                   Name == dTO.Name &&
                   DirectionName == dTO.DirectionName;
        }
    }
}