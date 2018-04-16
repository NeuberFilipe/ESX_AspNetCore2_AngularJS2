using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace ESX.IoC
{
    public class IoCConfiguration
    {
        public static void Configure(IServiceCollection service)
        {
            Configure(service, Data.IoC.Module.GetTypes());
            Configure(service, Services.IoC.Module.GetTypes());
            Configure(service, Domain.IoC.Module.GetTypes());
            Configure(service, Aplication.Service.IoC.Module.GetTypes());
        }

        public static void Configure(IServiceCollection services, Dictionary<Type, Type> types)
        {
            foreach (var type in types)
            {
                services.AddScoped(type.Key, type.Value);
            }
        }
    }
}
