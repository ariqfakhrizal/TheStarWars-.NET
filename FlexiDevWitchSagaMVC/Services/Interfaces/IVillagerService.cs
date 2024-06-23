using FlexiDevWitchSagaMVC.Models;
using System.Collections.Generic;

namespace FlexiDevWitchSagaMVC.Services.Interfaces
{
    public interface IVillagerService
    {
        double CalculateAverageKills(List<Person> people);
    }
}
