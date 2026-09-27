namespace TaskRunnerApp
{
    public class TaskRunner
    {
        public void Run(ITask task) {
            task.Run();
        }
    }
}


