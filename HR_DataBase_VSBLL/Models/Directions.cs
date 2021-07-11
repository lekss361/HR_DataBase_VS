namespace HR_DataBase_VSBLL.Models
{
    public class Directions
    {
        public int id { get; set; }
        public string Name { get; set; }

        public Directions()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Directions directions &&
                   id == directions.id &&
                   Name == directions.Name;
        }
    }
}