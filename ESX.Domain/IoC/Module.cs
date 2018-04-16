using System;
using System.Collections.Generic;

namespace ESX.Domain.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var dic = new Dictionary<Type, Type>();
            //dic.Add(typeof(Interfaces.ITodoDomainService), typeof(TodoDomainService));
            return dic;
        }
    }
}
