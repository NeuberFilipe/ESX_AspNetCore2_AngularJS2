using System;
using System.Collections.Generic;
using ESX.Aplication.Service.Extensions;
using ESX.Aplication.Service.Interfaces;
using ESX.Domain.Entities;
using ESX.Domain.Filters;
using ESX.Services.Interface;

namespace ESX.Aplication.Service
{
    internal class PersonAplicationService : IPersonAplicationService
    {
        private readonly IPersonService _personService;
        public PersonAplicationService(IPersonService personService)
        {
            _personService = personService;
        }
        public IEnumerable<PersonViewModel.PersonViewModel> GetLatestCalc(PersonFilterViewModel.PersonFilterViewModel personFilter)
        {
            return _personService.GetLatestCalc(personFilter.MapTo<PersonFilter>()).EnumerableTo<PersonViewModel.PersonViewModel>();
        }

        public PersonViewModel.PersonViewModel SaveCalc(PersonViewModel.PersonViewModel person)
        {
            return _personService.SaveCalc(person.MapTo<Person>()).MapTo<PersonViewModel.PersonViewModel>();
        }

        public bool Update(PersonViewModel.PersonViewModel person)
        {
            return _personService.Update(person.MapTo<Person>());
        }

        public bool Delete(Guid id)
        {
            return _personService.Delete(id);
        }

        public bool Insert(PersonViewModel.PersonViewModel person)
        {
            return _personService.Insert(person.MapTo<Person>());
        }

        public PersonViewModel.PersonViewModel GetById(Guid id)
        {
            return _personService.GetById(id).MapTo<PersonViewModel.PersonViewModel>();
        }

        public PersonViewModel.PersonViewModel CreatePerson(PersonViewModel.PersonViewModel person)
        {
           return _personService.CreatePerson(person.MapTo<Person>()).MapTo<PersonViewModel.PersonViewModel>();
        }
    }
}
