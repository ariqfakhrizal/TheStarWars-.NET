using FlexiDevWitchSagaMVC.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace FlexiDevWitchSagaMVC.Services.Implementations
{
    public class WitcherService : IWitcherService
    {
        // This is similiar with Fibonacci need to add + 1;
        // Using the const because by case in PDF it static + 1

        const int additionalCounter = 1;
        public List<int> CalculateDeathsPerYear(int years)
        {
            try
            {
                if (years < 0)
                {
                    // negative age, person who born before the witch took control
                    return new List<int> { -1 };
                }

                List<int> deathsPerYear = new List<int>();

                // This is similiar with Fibonacci need to add + 1;

                int lastYearKillings = 1; // Previous year killings
                int secondLastYearKillings = 0; // Year before last killings
                int currentYearKillings = 1; // Current year killings

                deathsPerYear.Add(lastYearKillings);

                // Initially the plan was to use it as a logger, but needed to install other references
                Console.WriteLine("On the 1st year she kills " + lastYearKillings + " villager");

                for (int i = 2; i <= years; i++)
                {
                    currentYearKillings = lastYearKillings + secondLastYearKillings + additionalCounter;
                    secondLastYearKillings = lastYearKillings;
                    lastYearKillings = currentYearKillings;
                    deathsPerYear.Add(lastYearKillings);

                    // Initially the plan was to use it as a logger, but needed to install other references
                    Console.WriteLine("On the " + i + "st year she kills " + lastYearKillings + " villagers");
                }

                return deathsPerYear;
            }
            catch (ArgumentException ex)
            {
                // Initially the plan was to use it as a logger, but needed to install other references
                Console.WriteLine($"Error: {ex.Message}");
                return new List<int> { -1 };
            }
        }
    }
}