namespace WorkflowEngine
{

    public partial class Program
    {
        public interface IWorkflow
        {
            IEnumerable<ITask> GetTasks();
            void AddTask(ITask task);
            void RemoveTask(ITask task);
        }
    
    
    
    }



}
