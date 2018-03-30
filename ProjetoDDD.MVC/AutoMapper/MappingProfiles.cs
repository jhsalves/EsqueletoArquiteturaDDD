

using AutoMapper;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.MVC.ViewModels;
namespace ProjetoDDD.MVC.AutoMapper
{
    public class MappingProfiles : Profile
    {
        public override string ProfileName => "MappingProfiles";

        public MappingProfiles()
        {
            Mapper.Initialize(config => {
                config.CreateMap<ProdutoViewModel, Produto>();
                config.CreateMap<ProdutoViewModel, Produto>().ReverseMap();
                config.CreateMap<ClienteViewModel, Cliente>();
                config.CreateMap<ClienteViewModel, Cliente>().ReverseMap();
            });
        }
    }
}