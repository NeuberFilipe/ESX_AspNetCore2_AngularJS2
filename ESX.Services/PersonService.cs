using System;
using System.Collections.Generic;
using ESX.Domain.Entities;
using ESX.Domain.Filters;
using ESX.Services.Interface;
using ESX.Data.Repository.Person;

namespace ESX.Services
{
    internal class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public IEnumerable<Person> GetLatestCalc(PersonFilter personFilter)
        {
            return _personRepository.GetLatestCalc(personFilter);
        }

        public Person SaveCalc(Person person)
        {
            return _personRepository.SaveCalc(person);
        }

        public bool Update(Person person)
        {
            return _personRepository.Update(person);
        }

        public bool Delete(Guid id)
        {
            return _personRepository.Delete(id);
        }

        public bool Insert(Person person)
        {
            return _personRepository.Insert(person);
        }

        public Person GetById(Guid id)
        {
            return _personRepository.GetById(id);
        }

        public Person CreatePerson(Person person)
        {
            return _personRepository.CreatePerson(person);
        }
    }
}
