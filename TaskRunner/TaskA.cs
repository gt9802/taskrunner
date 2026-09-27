using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRunnerApp
{
    public class TaskA : ITask
    {
        public void Run()
        {
            Console.WriteLine("A");
        }
    }
}
