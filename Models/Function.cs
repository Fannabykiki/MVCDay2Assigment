using System.Diagnostics;
namespace MVCAssigment.Models
{
    public static class Function
    {
        public static List<Person> AddMember()
        {
            List<Person> person = new List<Person>();
            person.Add(new Person
            {
                FirstName = "Phan",
                LastName = "Nam",
                Gender = "Male",
                DateOfBirth = new DateTime(1999, 10, 18),
                PhoneNumber = "0396373132",
                BirthPlace = "Ha Noi",
                Age = 21,
                IsGraduated = true
            });

            person.Add(new Person
            {
                FirstName = "Tran",
                LastName = "Linh",
                Gender = "FeMale",
                DateOfBirth = new DateTime(2003, 10, 15),
                PhoneNumber = "0396373132",
                BirthPlace = "Bac Ninh",
                Age = 29,
                IsGraduated = false
            });

            person.Add(new Person
            {
                FirstName = "Dao",
                LastName = "Trang",
                Gender = "FeMale",
                DateOfBirth = new DateTime(2003, 07, 13),
                PhoneNumber = "0396373132",
                BirthPlace = "SG",
                Age = 29,
                IsGraduated = true
            });

            person.Add(new Person
            {
                FirstName = "Vu",
                LastName = "Kim",
                Gender = "Male",
                DateOfBirth = new DateTime(2003, 11, 30),
                PhoneNumber = "0396373132",
                BirthPlace = "Ha Noi",
                Age = 29,
                IsGraduated = true
            });

            person.Add(new Person
            {
                FirstName = "Duy",
                LastName = "Anh",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 11, 30),
                PhoneNumber = "0396373132",
                BirthPlace = "Ha Noi",
                Age = 21,
                IsGraduated = true
            });
            return person;
        }

        public static Person GetOldestPerson(List<Person> list)
        {
            Person p = new Person();
            foreach (Person item in list)
            {
                if (item.Age > p.Age)
                {
                    p = item;
                }
            }
            return p;
        }

        public static void GetFullNameOfPerson(List<Person> list)
        {
            foreach (Person item in list)
            {
                string FullName = item.LastName + " " + item.FirstName;
                Debug.WriteLine(FullName);
            }
        }

        public static void WriteToFileByStream(string directoryPath, string fileName,string textContent)
        {
            using (var fileStream = new FileStream(Path.Combine(directoryPath, fileName), FileMode.OpenOrCreate))
            {
                using (var writer = new StreamWriter(fileStream))
                {
                    writer.WriteLine(textContent);
                }
            }
        }
    }
}