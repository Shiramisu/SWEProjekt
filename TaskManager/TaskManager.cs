using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class TaskManager
    {
        public List<Task> tasks = new List<Task>();
        public void addTask(string task)
        {
            tasks.Add(new Task(task));
        }
        public void markTaskAsCompleted(int index)
        {
            if (index >= 0 && index < tasks.Count)
            tasks[index].Completed();
        }
        public void showCompletedTasks()
        {
            foreach (Task manager in tasks)
            {
                if(manager.completed)
                Console.WriteLine(manager.task);
            }
        }
        public void showTasks()
        {
            foreach (Task manager in tasks)
            {
                Console.WriteLine(manager.task);
            }
        }
    }
}
