using MVCAssigment.DataAccess;
using MVCAssigment.Services.Container;

namespace MVCAssigment.Services
{
    public class MemberServices : IServicesInterface
    {
        private readonly IDataAccess _dataAccess;
        public MemberServices(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void AddPerson(PersonCreateModel personCreate)
        {
            PersonViewModel person = new PersonViewModel()
            {   
                FirstName = personCreate.FirstName,
                LastName = personCreate.LastName,
                DateOfBirth = personCreate.DateOfBirth,
                PhoneNumber = personCreate.PhoneNumber,
                Gender = personCreate.Gender,
                BirthPlace = personCreate.BirthPlace,
                Age = 20,
                IsGraduated = false
            };
            _dataAccess.AddPerson(person);
        }
        public List<PersonViewModel> ListPerson()
        {
            var listApplicationModels = _dataAccess.ShowAllPerson();
            
            var listCreateModels = new List<PersonViewModel>();
            foreach (var item in listApplicationModels)
            {   
                listCreateModels.Add( new PersonViewModel {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    DateOfBirth = item.DateOfBirth,
                    Age =20,
                    Gender = item.Gender,
                    IsGraduated= false,
                    PhoneNumber = item.PhoneNumber,
                    BirthPlace = item.BirthPlace                 
                });
            }

            return listCreateModels;
        }
    }
}