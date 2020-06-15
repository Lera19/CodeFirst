using BusinessLayer;
using System;

namespace FirstCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var manager = new Manager();
            var tasks = manager.GetAllTasks();
            foreach (var t in tasks)
            {
                Console.WriteLine($"ID: {t.ID}, Tasks: {t.NameTasks} Status: {t.TasksCompleted.Status}");
                foreach (var c in t.Categories)
                {
                    Console.WriteLine($"Categories {c.Name}");
                    Console.WriteLine("---------------------");
                }
            }
            manager.GetAllTasksAfterUpdate();

            Console.ReadKey();
        }
    }
}