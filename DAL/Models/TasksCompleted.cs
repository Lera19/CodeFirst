namespace DAL.Models
{
    public class TasksCompleted
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public override string ToString()
        {
            return $"{Status}";
        }
    }
}
