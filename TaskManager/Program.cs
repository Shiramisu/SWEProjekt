using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create new TaskManager
            TaskManager manager = new TaskManager();


            // add two tasks
            manager.addTask("Lern Java");
            manager.addTask("Write Code");


            // show tasks
            manager.showTasks();


            //mark second task as completed
            manager.markTaskAsCompleted(1);
            // show completed tasks
            manager.showCompletedTasks();


            // Line to prevent window to immediately close
            Console.Write("Pres any key to exit..."); Console.ReadKey();
        }
    }
}
