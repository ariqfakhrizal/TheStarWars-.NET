using FlexiDevWitchSagaMVC.Models;
using FlexiDevWitchSagaMVC.Services.Implementations;
using FlexiDevWitchSagaMVC.Services.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace FlexiDevWitchSagaMVC.Tests.Services
{
    [TestFixture]
    public class VillagerServiceTests
    {
        private VillagerService _villagerService;
        private Mock<IWitcherService> _mockWitcherService;

        [SetUp]
        public void Setup()
        {
            _mockWitcherService = new Mock<IWitcherService>();
            _villagerService = new VillagerService(_mockWitcherService.Object);
        }

        [Test]
        public void CalculateAverageKills_ValidInput_ReturnsCorrectAverage()
        {
            // Arrange - Following Rules in PDF by Witcher
            _mockWitcherService.Setup(s => s.CalculateDeathsPerYear(It.IsAny<int>()))
                               .Returns(new List<int> { 1, 2, 4, 7, 12 });

            var people = new List<Person>
            {
                new Person { AgeOfDeath = 10, YearOfDeath = 12 }
            };

            // Act
            double averageKills = _villagerService.CalculateAverageKills(people);

            // Assert
            Assert.That(Math.Round(averageKills, 2), Is.EqualTo(2)); // Example expected average kills
        }

        [Test]
        public void CalculateAverageKills_InvalidYearOfBirth_ReturnsMinusOne()
        {
            // Arrange - Following Rules in PDF by Witcher
            _mockWitcherService.Setup(s => s.CalculateDeathsPerYear(It.IsAny<int>()))
                               .Returns(new List<int> { 1, 2, 4, 7, 12 });

            var people = new List<Person>
            {
                new Person { AgeOfDeath = 10, YearOfDeath = 12 }, // Example person 1
                new Person { AgeOfDeath = 13, YearOfDeath = 17 }, // Example person 2
                new Person { AgeOfDeath = 80, YearOfDeath = -1 }     // Invalid year of death
            };

            // Act
            double averageKills = _villagerService.CalculateAverageKills(people);

            // Assert
            Assert.That(Math.Round(averageKills, 2), Is.EqualTo(-1)); // Example expected average kills
        }
    }
}
