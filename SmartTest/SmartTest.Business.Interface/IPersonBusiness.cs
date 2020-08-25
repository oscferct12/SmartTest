namespace SmartTest.Business.Interface
{
    using SmartTest.DataAccess.Models;
    using SmartTest.Response.Response;
    public interface IPersonBusiness
    {
        ModelResponse<Person> GetPersons();

        ModelResponse<Person> CreatePerson(Person person);

        ModelResponse<bool> DeletePerson(string id);

        ModelResponse<Person> UpdatePerson(Person person);

        ModelResponse<PersonType> GetPersonTypes();
    }
}
