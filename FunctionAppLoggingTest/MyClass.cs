using Microsoft.Extensions.Logging;

namespace FunctionAppLoggingTest
{
    public class MyClass
    {
        private readonly ILogger<MyClass> _logger;

        public MyClass(ILogger<MyClass> logger) =>
            _logger = logger;

        public void DoSomething() =>
            _logger.LogInformation("This log doesn't appear!");
    }
}