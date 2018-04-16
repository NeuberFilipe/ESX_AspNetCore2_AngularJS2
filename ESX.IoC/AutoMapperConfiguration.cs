using System;
using System.Collections.Generic;

namespace ESX.IoC
{
   public class AutoMapperConfiguration
    {
        public static IEnumerable<Type> GetAutoMapperProfiles()
        {
            var result = new List<Type>();
            result.Add(typeof(Aplication.Service.Mappings.MappingProfile));
            return result;
        }
    }
}
