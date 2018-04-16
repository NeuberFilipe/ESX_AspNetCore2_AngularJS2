namespace ESX.UI.Web.Core.Mappings
{
    public static class AutoMapperConfiguration
    {
        public static void Initialize()
        {
            AutoMapper.Mapper.Initialize((cfg) =>
            {
                cfg.AddProfiles(ESX.IoC.AutoMapperConfiguration.GetAutoMapperProfiles());
            });
        }
    }
}
