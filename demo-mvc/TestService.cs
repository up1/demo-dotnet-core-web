using System;
using Microsoft.Extensions.Logging;

namespace demo_mvc
{
    public class TestService
    {
        private readonly ILogger<TestService> logger;

        public TestService(ILogger<TestService> logger)
        {
            this.logger = logger;

        }

        public void Test()
        {
            logger.LogWarning("I'm writing a message");
        }
    }
}
