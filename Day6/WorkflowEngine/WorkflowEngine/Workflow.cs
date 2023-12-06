namespace WorkflowEngine
{

    public partial class Program
    {
        public class Workflow : IWorkflow
        {
            private List<ITask> _tasks;

            public Workflow ()
            {
                _tasks = new List<ITask>();
            }
        
            public void AddTask(ITask task)
            {
                _tasks.Add(task);
            }
            public void RemoveTask(ITask task)
            {
                _tasks.Remove(task);
            }
            public IEnumerable <ITask> GetTasks()
            {
                return _tasks;
            }
        }
    
    
    
    }



}
