using DAL;
using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BusinessLayer
{
    public class Manager
    {
        public IList<Tasks> GetAllTasks()
        {
            using (var context = new TaskContext())
            {
                var result = context.Tasks.Include(c => c.TasksCompleted).Include(c => c.Categories).ToList();
                return result;
            }
        }
        public int GetAllTasksAfterUpdate()
        {
            using (var context = new TaskContext())
            {
                var param = context.Database.ExecuteSqlCommand(
                    "UPDATE Tasks SET TasksCompleted_ID = 2 from Tasks where TasksCompleted_ID = 1");
                return param;

            }
        }

    }
}