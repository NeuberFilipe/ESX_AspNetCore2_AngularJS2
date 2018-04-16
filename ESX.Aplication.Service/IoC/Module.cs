using System;
using System.Collections.Generic;
using ESX.Aplication.Service.Interfaces;

namespace ESX.Aplication.Service.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var register = new Dictionary<Type, Type>();
            register.Add(typeof(IPersonAplicationService), typeof(PersonAplicationService));
            return register;
        }
    }
}
