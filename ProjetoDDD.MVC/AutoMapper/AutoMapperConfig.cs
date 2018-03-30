using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoDDD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper Mapper;
        public static void RegisterMappings()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfiles());
            });

            Mapper = config.CreateMapper();
            config.AssertConfigurationIsValid();
        }
    }
}