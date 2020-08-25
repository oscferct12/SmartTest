namespace SmartTest.Repository
{
    using SmartTest.DataAccess;
    using SmartTest.DataAccess.Models;
    using SmartTest.Repository.Interface;
    using SmartTest.Response.Response;
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;

    public class PersonRepository : IPersonRepository
    {
        private readonly Collection<Person> _listPerson;
        private readonly Collection<PersonType> _listPersonType;
        private readonly SmartTestContext _context;

        public PersonRepository(SmartTestContext context)
        {
            _listPerson = new Collection<Person>();
            _listPersonType = new Collection<PersonType>();
            _context = context;
        }

        public ModelResponse<Person> CreatePerson(Person person)
        {
            int id;
            try
            {
                if (person == null)
                    return ManagerResponse<Person>.ResponseError("Null Values");

                int idTransactionCode = 0;
                bool inserted = false;

                _context.Persons.Add(person);
                _context.SaveChanges();
                id = person.Id ?? default(int);

                if (idTransactionCode > 0)
                    inserted = true;

                return ManagerResponse<Person>.ResponseOk(idTransactionCode, new Collection<Person> { person });
            }
            catch (Exception)
            {
                return ManagerResponse<Person>.ResponseError("Error to Insert");
                throw new NotImplementedException();
            }
        }

        public ModelResponse<bool> DeletePerson(string id)
        {
            try
            {
                var entity = _context.Persons.First(t => t.Id == Convert.ToInt32(id));
                _context.Persons.Remove(entity);
                _context.SaveChanges();

                return ManagerResponse<bool>.ResponseOk(_context.SaveChanges());
            }
            catch (Exception)
            {
                return ManagerResponse<bool>.ResponseError("Error to delete");
                throw new NotImplementedException();
            }
        }

        public ModelResponse<Person> GetPersons()
        {
            _listPerson.Clear();
            int idTransactionCode = 0;
            var result = _context.Persons.OrderBy(li => li.Id).ToList();

            if (result != null && result.Any())
            {
                idTransactionCode = 1;

                foreach (var item in result)
                {
                    _listPerson.Add(item);
                }
            }

            if (_listPerson.Count > 0)
                return ManagerResponse<Person>.ResponseOk(idTransactionCode > 0 ? 1 : 0, _listPerson);
            else
                return ManagerResponse<Person>.ResponseNoContent("Data is null");

            throw new NotImplementedException();
        }

        public ModelResponse<PersonType> GetPersonTypes()
        {
            _listPersonType.Clear();
            int idTransactionCode = 0;
            var result = _context.PersonTypes.OrderBy(li => li.Id).ToList();

            if (result != null && result.Any())
            {
                idTransactionCode = 1;

                foreach (var item in result)
                {
                    _listPersonType.Add(item);
                }
            }

            if (_listPersonType.Count > 0)
                return ManagerResponse<PersonType>.ResponseOk(idTransactionCode > 0 ? 1 : 0, _listPersonType);
            else
                return ManagerResponse<PersonType>.ResponseNoContent("Data is null");

            throw new NotImplementedException();
        }

        public ModelResponse<Person> UpdatePerson(Person person)
        {
            try
            {
                if (person == null)
                    return ManagerResponse<Person>.ResponseError("Null Values");

                int idTransactionCode = 0;
                bool edited = false;

                _context.Persons.Update(person);
                idTransactionCode = _context.SaveChanges();

                if (idTransactionCode > 0)
                    edited = true;

                return ManagerResponse<Person>.ResponseOk(idTransactionCode, new Collection<Person> { person });
            }
            catch (Exception)
            {
                return ManagerResponse<Person>.ResponseError("Error to Edit");
                throw new NotImplementedException();
            }
        }
    }
}
