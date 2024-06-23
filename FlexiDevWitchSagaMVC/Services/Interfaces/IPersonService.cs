using FlexiDevWitchSagaMVC.Models;

namespace FlexiDevWitchSagaMVC.Services.Interfaces
{
    public interface IPersonService
    {
        int CalculateYearOfBirth(Person person);
    }
}
