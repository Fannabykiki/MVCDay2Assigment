namespace MVCAssigment.DataAccess
{
    public class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? BirthPlace { get; set; }
        public uint Age { get; set; }
        public bool? IsGraduated { get; set; }

        public Person(string firstname, string lastname, int gender, DateTime dob,
         string phonenumber, string birthplace, uint age, bool isgraduated)
        {
            FirstName = firstname;
            LastName = lastname;
            Gender = gender;
            DateOfBirth = dob;
            PhoneNumber = phonenumber;
            BirthPlace = birthplace;
            Age = age;
            IsGraduated = isgraduated;
        }

        public Person()
        {
        }

        public override string ToString()
        {

            return $"Member's Information: FirstName: {FirstName} – LastName: {LastName} – Gender:{Gender} -Age: {Age} - Phone : {PhoneNumber} - Date of birth: {DateOfBirth} - Birth Place: {BirthPlace} - IsGraduated:{IsGraduated} ";
        }


    }
}