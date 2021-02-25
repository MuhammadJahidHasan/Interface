namespace Interface
{
    class SendSms : IActivities
    {
        public void Execute()
        {
           System.Console.WriteLine("Sending a sms...");
        }
    }
}
