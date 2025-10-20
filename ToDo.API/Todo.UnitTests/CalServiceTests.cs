using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Application;
using Xunit;

namespace Todo.UnitTests
{
    public class CalServiceTests
    {
        [Fact]
        public void AddTest_Succsss()
        {
            // Arrange
            var cal = new CalService();

            // Act
            var result = cal.Add(1, 2);

            // Assert
            Assert.Equal(3, result);
        }
    }
}
