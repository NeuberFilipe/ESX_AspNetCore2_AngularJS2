using System;
using System.Collections.Generic;
using ESX.Services.Interface;

namespace ESX.Services.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var dic = new Dictionary<Type, Type>();
            dic.Add(typeof(IPersonService), typeof(PersonService));
            return dic;
        }
    }
}
