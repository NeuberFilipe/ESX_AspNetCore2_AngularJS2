using System;
using System.Collections.Generic;
using ESX.Data.Repository.Person;

namespace ESX.Data.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var register = new Dictionary<Type, Type>();
            register.Add(typeof(IPersonRepository), typeof(PersonRepository));
            return register;
        }
    }
}
