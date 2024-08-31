using AutoMapper;
using Desafio.B3.Api.ViewModels;
using Desafio.B3.Business.Domain;

namespace Desafio.B3.Api.Configurations
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Cdb, CdbViewModel>().ReverseMap();                        
        }
    }
}
