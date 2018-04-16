using System;
using System.Collections.Generic;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace ESX.Data.Repository.Person
{
    internal class PersonRepository : RepositoryBase, IPersonRepository
    {
        public PersonRepository(IConfiguration config) : base(config)
        {

        }
        public Domain.Entities.Person CreatePerson(Domain.Entities.Person person)
        {
            person.Id = connection.QueryFirst<Guid>(
                "Exec Person_esx_create @Id, @Name, @Email, @Salary, @SalaryLiq, @SalaryBru, @Tax, @DateCalc", person);
            return person;
        }

        public IEnumerable<Domain.Entities.Person> GetLatestCalc(Domain.Filters.PersonFilter personFilter)
        {
            return connection.Query<Domain.Entities.Person>(
                "Exec Person_esx_getall @Id, @Name, @Email, @Salary, @SalaryLiq, @SalaryBru, @Tax", personFilter);
        }

        public Domain.Entities.Person SaveCalc(Domain.Entities.Person person)
        {
            connection.Execute(
                "Exec person_esx_saveCal @Name, @Email, @Salary, @SalaryLiq, @SalaryBru, @Tax, @DateCalc", person);
            return person;
        }

        public bool Update(Domain.Entities.Person person)
        {
            var affectedRows = connection.Execute(
                  "Exec Person_esx_update  @Id, @Name, @Email, @Salary, @SalaryLiq, @SalaryBru, @Tax, @DateCalc", person);
            return affectedRows > 0;
        }

        public bool Delete(Guid id)
        {
            var affectedRows = connection.Execute("Exec Person_esx_delete @Id", new { Id = id });
            return affectedRows > 0;
        }

        public bool Insert(Domain.Entities.Person person)
        {
            throw new NotImplementedException();
        }

        public Domain.Entities.Person GetById(Guid id)
        {
            return connection.QueryFirstOrDefault<Domain.Entities.Person>("Exec Person_esx_getbyId  @Id", new { Id = id });
        }
    }
}
