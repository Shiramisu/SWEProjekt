using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class Task
    {
        // name of the task:
        public string task = "";
        // completionstatus:
        public bool completed = false;


        // Sets "completed" to true
        public void Completed()
        {
            completed = true;
        }


        // Constructor
        public Task(string _task)
        {
            this.task = _task;
        }


        // Converts class to text
        public override string ToString()
        {
            // returns task with completion status

            if (completed)
                return "[X]" + task;
                //return "[✔]" + task;
            else
                return "[ ]" + task;
                //return "[❌]" + task;
        }
    }
}
