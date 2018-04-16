using System;

namespace ESX.Domain.Entities
{
   public class Person
    {

        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public decimal Salary { get; set; }

        public decimal SalaryLiq { get; set; }

        public decimal SalaryBru { get; set; }

        public decimal Tax { get; set; }

        public DateTime DateCalc { get; set; }
    }
}
