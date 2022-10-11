namespace MVCAssigment.DataAccess
{
    public class StaticDataAccess
    {
        List<Person> listPerson = new List<Person>(){
            new Person
            {
                FirstName = "Phan",
                LastName = "Nam",
                Gender = "Male",
                DateOfBirth = new DateTime(1999, 10, 18),
                PhoneNumber = "0396373132",
                BirthPlace = "Ha Noi",
                Age = 21,
                IsGraduated = true
            },
            new Person
            {
                FirstName = "Tran",
                LastName = "Linh",
                Gender = "Male",
                DateOfBirth = new DateTime(2003, 10, 15),
                PhoneNumber = "0396373132",
                BirthPlace = "Bac Ninh",
                Age = 29,
                IsGraduated = false
            },
            new Person
            {
                FirstName = "Dao",
                LastName = "Trang",
                Gender = "FeMale",
                DateOfBirth = new DateTime(2003, 07, 13),
                PhoneNumber = "0396373132",
                BirthPlace = "SG",
                Age = 29,
                IsGraduated = true
            },
            new Person
            {
                FirstName = "Duy",
                LastName = "Anh",
                Gender = "FeMale",
                DateOfBirth = new DateTime(2000, 11, 30),
                PhoneNumber = "0396373132",
                BirthPlace = "Ha Noi",
                Age = 21,
                IsGraduated = true
            }
        };

        public StaticDataAccess(){
            
        }
        public List<Person> ShowAllPerson()
        {
            return listPerson;
        }

        public void AddPerson(Person person)
        {
             listPerson.Add(person);
        }
    }
}