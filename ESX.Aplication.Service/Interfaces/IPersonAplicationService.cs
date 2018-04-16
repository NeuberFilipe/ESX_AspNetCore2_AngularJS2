using System;
using System.Collections.Generic;

namespace ESX.Aplication.Service.Interfaces
{
    public interface IPersonAplicationService
    {
        IEnumerable<PersonViewModel.PersonViewModel> GetLatestCalc(PersonFilterViewModel.PersonFilterViewModel personFilter);

        PersonViewModel.PersonViewModel SaveCalc(PersonViewModel.PersonViewModel person);

        bool Update(PersonViewModel.PersonViewModel person);

        bool Delete(Guid id);

        bool Insert(PersonViewModel.PersonViewModel person);

        PersonViewModel.PersonViewModel GetById(Guid id);

        PersonViewModel.PersonViewModel CreatePerson(PersonViewModel.PersonViewModel person);
    }
}
