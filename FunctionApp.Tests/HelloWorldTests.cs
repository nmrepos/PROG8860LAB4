using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using Xunit;
using FunctionApp;

public class HelloWorldTests
{
    [Fact]
    public async Task Run_ReturnsHelloWorld()
    {
        // Arrange
        var context = new DefaultHttpContext();
        var request = context.Request;
        var logger = NullLoggerFactory.Instance.CreateLogger("Test");

        // Act
        var result = await HelloWorld.Run(request, logger) as OkObjectResult;

        // Assert
        Assert.NotNull(result);
        Assert.Equal("Hello, world!", result.Value);
    }
}
