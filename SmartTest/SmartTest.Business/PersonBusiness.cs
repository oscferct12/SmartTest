
namespace SmartTest.Business
{
    using SmartTest.Business.Interface;
    using SmartTest.DataAccess.Models;
    using SmartTest.Repository.Interface;
    using SmartTest.Response.Response;
    using System;

    public class PersonBusiness : IPersonBusiness
    {
        /// <summary>
        /// Instance of IPersonRepository.
        /// </summary>
        private readonly IPersonRepository _personRepository;

        public PersonBusiness(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public ModelResponse<Person> CreatePerson(Person person)
        {
            try
            {
                return _personRepository.CreatePerson(person);
            }
            catch (Exception ex)
            {
                return ManagerResponse<Person>.ResponseError(ex.Message);
            }
        }

        public ModelResponse<bool> DeletePerson(string id)
        {
            try
            {
                return _personRepository.DeletePerson(id);
            }
            catch (Exception ex)
            {
                return ManagerResponse<bool>.ResponseError(ex.Message);
            }
        }

        public ModelResponse<Person> GetPersons()
        {
            try
            {
                return _personRepository.GetPersons();
            }
            catch (Exception ex)
            {
                return ManagerResponse<Person>.ResponseError(ex.Message);
            }
        }

        public ModelResponse<PersonType> GetPersonTypes()
        {
            try
            {
                return _personRepository.GetPersonTypes();
            }
            catch (Exception ex)
            {
                return ManagerResponse<PersonType>.ResponseError(ex.Message);
            }
        }

        public ModelResponse<Person> UpdatePerson(Person person)
        {
            try
            {
                return _personRepository.UpdatePerson(person);
            }
            catch (Exception ex)
            {
                return ManagerResponse<Person>.ResponseError(ex.Message);
            }
        }
    }
}
