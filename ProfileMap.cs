using AutoMapper;

namespace AnaliseCasoAPI
{
    public class ProfileMap : Profile
    {
        public ProfileMap()
        {
            CreateMap<ModeloEntradaDados, SaidaDados>().ForMember(destino => destino.Street, entrada => entrada.MapFrom(p => p.Endereco.Street));
         //   CreateMap<SaidaDados, ModeloEntradaDados>().ForMember(pm => pm.Endereco.Street, opt => opt.MapFrom(p => p.Street));
        }
 
    }
}
