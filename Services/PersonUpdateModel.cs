using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCAssigment.Services
{
    public class PersonUpdateModel
    {
        [DisplayName("First Name"), Required(ErrorMessage = "{0} is required!!")]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? BirthPlace { get; set; }

        public PersonUpdateModel()
        {
        }
    }
}