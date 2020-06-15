using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class Initializer : CreateDatabaseIfNotExists<TaskContext>
    {
        protected override void Seed(TaskContext context)
        {
            var taskcompleted = new List<TasksCompleted>()
            { 
                new TasksCompleted() { ID=2, Status="Done"},
                new TasksCompleted() { ID=1, Status="Not done"}
            };
            var categories = new List<Categories>()
            {
                new Categories() {ID=1, Name="Sport"},
                new Categories() {ID=2, Name="Relax"},
                new Categories() {ID=3, Name="Study"}
            };

            var tasks = new List<Tasks>()
            {
                new Tasks() {ID=1, NameTasks="Play tennis",
                    Categories=categories.Where(c => c.ID==1 && c.ID==2).ToList(),
                    TasksCompleted=taskcompleted.FirstOrDefault()},

                new Tasks() {ID=2, NameTasks="Sleep", 
                    Categories=categories.Where(c=>c.ID==2).ToList(), 
                    TasksCompleted=taskcompleted.FirstOrDefault()},

                new Tasks() {ID=3, NameTasks="Go to school",
                    Categories=categories.Where(c=>c.ID==3).ToList(),
                    TasksCompleted=taskcompleted.FirstOrDefault()},

                new Tasks() {ID=4, NameTasks="PLAY football",  
                    Categories=categories.Where(c=>c.ID==1).ToList(),
                    TasksCompleted=taskcompleted.FirstOrDefault()},

                new Tasks() {ID=5, NameTasks="Watching film",  
                    Categories=categories.Where(c=>c.ID==2).ToList(),
                    TasksCompleted=taskcompleted.FirstOrDefault()},

                new Tasks() {ID=6, NameTasks="To do homework", 
                    Categories=categories.Where(c=>c.ID==3).ToList(),
                    TasksCompleted=taskcompleted.FirstOrDefault()},
            };

            
            context.Tasks.AddRange(tasks);
            context.TasksCompleted.AddRange(taskcompleted);
            context.Categories.AddRange(categories);

            context.SaveChanges();
        }
    }
}