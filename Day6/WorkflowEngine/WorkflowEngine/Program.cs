using System;
namespace WorkflowEngine
{

    public partial class Program
    {
        public static void Main(string[] args)
        {
      
            
            
            
            
            
            Workflow newworkflow = new Workflow();
            newworkflow.AddTask(new VideoUploader());
            newworkflow.AddTask(new CallWebService());
            newworkflow.AddTask(new SendEmail());
            newworkflow.AddTask(new ChangeStatus());
            
            
            
            var engine =  new WorkflowEngine();
            engine.Run(newworkflow);
            Console.ReadLine();
        }
    
    
    
    }



}
