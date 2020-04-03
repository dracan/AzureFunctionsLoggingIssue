using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionAppLoggingTest
{
    public class TestQueueTriggerFunction
    {
        private readonly MyClass _myClass;

        public TestQueueTriggerFunction(MyClass myClass) =>
            _myClass = myClass;

        [FunctionName("TestQueueTriggerFunction")]
        public Task RunAsync([QueueTrigger("myqueue", Connection = "AzureWebJobsStorage")] string myQueueItem, ILogger log)
        {
            log.LogInformation("Start of function (this log works)");
            _myClass.DoSomething();
            log.LogInformation("End of function (this log also works)");

            return Task.CompletedTask;
        }
    }
}