namespace HR_DataBase_VSBLL.Models
{
    public class PositionsWithDirectionName
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string DirectionName { get; set; }

        public override bool Equals(object obj)
        {
            return obj is PositionsWithDirectionName name &&
                   id == name.id &&
                   Name == name.Name &&
                   DirectionName == name.DirectionName;
        }
    }
}