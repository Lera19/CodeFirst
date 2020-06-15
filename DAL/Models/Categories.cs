using System.Collections.Generic;

namespace DAL.Models
{
    public class Categories
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}
