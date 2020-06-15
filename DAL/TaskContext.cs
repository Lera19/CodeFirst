using DAL.Models;
using System.Data.Entity;

namespace DAL
{
    public class TaskContext : DbContext
    {
        public TaskContext(): base("DefaultConnection")
        {
            Database.SetInitializer(new Initializer());
        }
        public DbSet <Tasks> Tasks { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<TasksCompleted> TasksCompleted { get; set; }
    }
}
