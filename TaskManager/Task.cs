using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class Task
    {
        public string task = "";
        public bool completed = false;
        public void Completed()
        {
            completed = true;
        }
        public Task(string _task)
        {
            this.task = _task;
        }
    }
}
