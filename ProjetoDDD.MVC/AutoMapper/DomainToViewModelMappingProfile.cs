

using AutoMapper;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.MVC.ViewModels;
namespace ProjetoDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName => "DomainToViewModelMappings";

        public DomainToViewModelMappingProfile()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Cliente, ClienteViewModel>();
                config.CreateMap<Produto, ProdutoViewModel>();
            });
        }
    }
}