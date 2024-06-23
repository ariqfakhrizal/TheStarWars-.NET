using FlexiDevWitchSagaMVC.Models;
using FlexiDevWitchSagaMVC.Services.Interfaces;

namespace FlexiDevWitchSagaMVC.Services.Implementations
{
    public class PersonService : IPersonService
    {
        public int CalculateYearOfBirth(Person person)
        {
            return person.YearOfBirth();
        }
    }
}