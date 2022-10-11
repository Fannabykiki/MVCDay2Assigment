using MVCAssigment.DataAccess;
namespace MVCAssigment.Services
{
    public class MemberServices
    {
        private readonly StaticDataAccess _dataAccess;
        public MemberServices()
        {
            _dataAccess = new StaticDataAccess();
        }

        public void AddPerson(PersonCreateModel personCreate)
        {
            Person person = new Person
            {
                FirstName = personCreate.FirstName,
                LastName = personCreate.LastName,
                DateOfBirth = personCreate.DateOfBirth,
                PhoneNumber = personCreate.PhoneNumber,
                Gender = personCreate.PhoneNumber,
                Age = 20,
                IsGraduated = false
            };
            _dataAccess.AddPerson(person);
        }
        public List<Person> ListPerson()
        {
            return _dataAccess.ShowAllPerson();
        }

    }
}