using NUnit.Framework;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using foo.Controllers;

namespace FooService.Tests
{
    public class WeatherForecastTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            var logger = new Logger<WeatherForecastController>(new NullLoggerFactory());
            var controller = new WeatherForecastController(logger);
            
            //Act
            var result = controller.Get();
            
            //Assert
            Assert.AreEqual(result.Count, 5);
        }
    }
}

