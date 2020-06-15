using System.Collections.Generic;

namespace DAL.Models
{
    public class Tasks
    {
        public Tasks()
        {
        }
        public int ID { get; set; }
        public string NameTasks { get; set; }
        public virtual ICollection<Categories> Categories { get; set; }
        public virtual TasksCompleted TasksCompleted { get; set; }

    }
}
