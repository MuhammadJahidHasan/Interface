using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
           var workflow = new Workflow();
             
           workflow.RegisterActivity(new UploadVideo());
           workflow.RegisterActivity(new SendSms());

           workflow.Run();  
        }
    }
}
