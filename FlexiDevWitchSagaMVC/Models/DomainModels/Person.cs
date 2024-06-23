namespace FlexiDevWitchSagaMVC.Models
{
    public class Person
    {

        // we can use modelState to make it required rules

        public int AgeOfDeath { get; set; }
        public int YearOfDeath { get; set; }

        public int YearOfBirth()
        {
            return YearOfDeath - AgeOfDeath;
        }
    }
}