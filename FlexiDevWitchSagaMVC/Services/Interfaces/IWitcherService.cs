using System.Collections.Generic;

namespace FlexiDevWitchSagaMVC.Services.Interfaces
{
    public interface IWitcherService
    {
        List<int> CalculateDeathsPerYear(int years);
    }
}
