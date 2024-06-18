using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();
            manager.addTask("Lern Java");
            manager.addTask("Write Code");
            manager.showTasks();

            manager.markTaskAsCompleted(1);
            manager.showCompletedTasks();

            Console.ReadKey();
        }
    }
}
