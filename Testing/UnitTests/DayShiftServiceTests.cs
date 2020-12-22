using System;
using FluentAssertions;
using NUnit.Framework;
using UnitTestsTarget;

namespace UnitTests
{
    public class DayShiftServiceTests
    {
        [Test]
        public void GetWednesday_ShiftFiveDays_ReturnsMonday()
        {
            // Arrange
            var today = new DateTime(2020, 12, 23);
            var daysToShift = 5;
            var service = new DayShiftService(new DayOfWeekService());
            
            // Act
            var result = service.GetShiftBusinessDay(today, daysToShift);
            
            // Assert
            result.Should().Be(new DateTime(2020, 12, 28));
        }
        
        [Test]
        public void GetTuesday_ShiftThreeDays_ReturnsFriday()
        {
            // Arrange
            var today = new DateTime(2020, 12, 22);
            var daysToShift = 3;
            var service = new DayShiftService(new DayOfWeekService());
            
            // Act
            var result = service.GetShiftBusinessDay(today, daysToShift);
            
            // Assert
            result.Should().Be(new DateTime(2020, 12, 25));
        }
        
        [Test]
        public void GetFriday_ShiftOneDay_ReturnsMonday()
        {
            // Arrange
            var today = new DateTime(2020, 12, 25);
            var daysToShift = 1;
            var service = new DayShiftService(new DayOfWeekService());
            
            // Act
            var result = service.GetShiftBusinessDay(today, daysToShift);
            
            // Assert
            result.Should().Be(new DateTime(2020, 12, 28));
        }
        
        [Test]
        public void GetSaturday_ShiftOneDay_ReturnsMonday()
        {
            // Arrange
            var today = new DateTime(2020, 12, 26);
            var daysToShift = 1;
            var service = new DayShiftService(new DayOfWeekService());
            
            // Act
            var result = service.GetShiftBusinessDay(today, daysToShift);
            
            // Assert
            result.Should().Be(new DateTime(2020, 12, 28));
        }
    }
}