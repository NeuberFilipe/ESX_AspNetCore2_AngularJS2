using System;
using System.Collections.Generic;

namespace ESX.Data.Repository.Person
{
  public interface IPersonRepository
  {
      IEnumerable<Domain.Entities.Person> GetLatestCalc (Domain.Filters.PersonFilter personFilter);

      Domain.Entities.Person SaveCalc(Domain.Entities.Person person);

      bool Update (Domain.Entities.Person person);

      bool Delete(Guid id);

      bool Insert(Domain.Entities.Person person);

      Domain.Entities.Person GetById(Guid id);

      Domain.Entities.Person CreatePerson(Domain.Entities.Person person);
  }
}
