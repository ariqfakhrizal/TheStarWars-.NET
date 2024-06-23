using FlexiDevWitchSagaMVC.Models;
using FlexiDevWitchSagaMVC.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlexiDevWitchSagaMVC.Services.Implementations
{
    public class VillagerService : IVillagerService
    {
        private readonly IWitcherService _witcherService;

        public VillagerService(IWitcherService witcherService)
        {
            _witcherService = witcherService;
        }
        public double CalculateAverageKills(List<Person> people)
        {
            try
            {
                if (people == null || !people.Any())
                {
                    // Initially the plan was to use it as a logger, but needed to install other references
                    Console.WriteLine("Person is null, return -1");

                    // Invalid input: empty or null list
                    return -1;
                }

                int maxYearOfBirth = people.Max(p => p.YearOfBirth());
                List<int> deathsPerYear = _witcherService.CalculateDeathsPerYear(maxYearOfBirth);

                if (deathsPerYear == null || deathsPerYear.Count == 0)
                {
                    // Invalid data: null or empty
                    return -1;
                }

                int totalKills = 0;
                int personCount = 0;

                foreach (var person in people)
                {
                    if (person.AgeOfDeath <= 0 || person.YearOfDeath <= 0 || person.YearOfBirth() <= 0)
                    {
                        // negative age, person who born before the witch took control
                        return -1;
                    }

                    int yearOfBirth = person.YearOfBirth();

                    if (yearOfBirth > 0)
                    {
                        totalKills += deathsPerYear[yearOfBirth - 1];
                        personCount++;
                    }
                    else
                    {
                        // Invalid data = zero or negative 
                        return -1;
                    }
                }

                if (personCount > 0)
                {
                    return (double)totalKills / personCount;
                }
                else
                {
                    return -1;
                }
            }
            catch (ArgumentException ex)
            {
                // Initially the plan was to use it as a logger, but needed to install other references
                Console.WriteLine($"Error: {ex.Message}");
                return -1;
            }
        }
    }
}