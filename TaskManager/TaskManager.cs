using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class TaskManager
    {
        // all Tasks
        public List<Task> tasks = new List<Task>();


        // adds a task to the list
        public void addTask(string task)
        {
            foreach (Task t in tasks)
            {
                if(t.task == task)
                {
                    Console.Write("Override [y/n] "+ '"' + t.task + '"');

                    // prevents dublicates
                    char key = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    if (key == 'y')
                    {
                        tasks.Remove(t);
                    }
                    else
                        return;
                }
            }
            tasks.Add(new Task(task));
        }


        // mark task as competed from index
        public void markTaskAsCompleted(int index)
        {
            if (index >= 0 && index < tasks.Count)
            tasks[index].Completed();
        }


        // mark task as competed from task name
        public void markTaskAsCompleted(string task)
        {
            foreach (Task tsk in tasks)
            {
                if(tsk.task == task)
                    tsk.Completed();
            }
        }


        // show all completed Tasks
        public void showCompletedTasks()
        {
            foreach (Task manager in tasks)
            {
                if(manager.completed)
                Console.WriteLine(manager.ToString());
            }
            Console.WriteLine();
        }


        // show all Tasks
        public void showTasks()
        {
            foreach (Task manager in tasks)
            {
                Console.WriteLine(manager.ToString());
            }
            Console.WriteLine("");
        }
    }
}
