using AutoMapper;
using Controle.Estoque.DTOs;
using Controle.Estoque.Models;

namespace Controle.Estoque.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Categoria, CategoriasDTO>().ReverseMap();
                config.CreateMap<Cidade, CidadeDTO>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
