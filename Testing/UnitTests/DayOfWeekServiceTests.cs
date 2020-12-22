using System;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using UnitTestsTarget;

namespace UnitTests
{
    public class DayOfWeekServiceTests
    {
        [Test]
        public void GetWorkingToday_CheckIfWeekend_ReturnsFalse()
        {
            // Arrange
            var today = new DateTime(2020, 12, 23);

            var service = new DayOfWeekService();
            
            // Act
            var result = service.IsWeekend(today);
            
            // Assert
            result.Should().Be(false);
        }
        
        [Test]
        public void GetWeekend_CheckIfWeekend_ReturnsTrue()
        {
            // Arrange
            var today = new DateTime(2020, 12, 26);

            var service = new DayOfWeekService();
            
            // Act
            var result = service.IsWeekend(today);
            
            // Assert
            result.Should().Be(true);
        }
    }
}