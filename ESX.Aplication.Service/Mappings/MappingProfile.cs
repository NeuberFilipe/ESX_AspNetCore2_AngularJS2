namespace ESX.Aplication.Service.Mappings
{
  public  class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<PersonViewModel.PersonViewModel, Domain.Entities.Person>().ReverseMap();
            CreateMap<PersonFilterViewModel.PersonFilterViewModel, Domain.Filters.PersonFilter>().ReverseMap();
        }
    }
}
