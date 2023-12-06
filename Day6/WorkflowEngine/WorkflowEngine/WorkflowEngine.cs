namespace WorkflowEngine
{

    public partial class Program
    {
        class WorkflowEngine
        {
            
            public void Run(IWorkflow workflow)
            {
                foreach (ITask I in workflow.GetTasks())
                {
                    I.Execute();
                }
            }
        }
    
    
    
    }



}
