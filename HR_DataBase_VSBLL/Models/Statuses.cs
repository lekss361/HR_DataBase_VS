namespace HR_DataBase_VSBLL.Models
{
    public class Statuses
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Statuses statuses &&
                   Name == statuses.Name;
        }
    }
}