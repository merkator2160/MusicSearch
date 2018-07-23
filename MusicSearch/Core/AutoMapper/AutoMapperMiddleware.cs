using AutoMapper;
using System.Reflection;

namespace MusicSearch.Core.AutoMapper
{
	internal static class AutoMapperMiddleware
    {
        public static IMapper GetConfiguredMapper()
        {
            var mapperConfiguration = new MapperConfiguration(RegisterMappings);
            mapperConfiguration.CompileMappings();
            return mapperConfiguration.CreateMapper();
        }
        private static void RegisterMappings(IMapperConfigurationExpression configure)
        {
            configure.AddProfiles(typeof(AutoMapperMiddleware).GetTypeInfo().Assembly);     // Dynamically load all configurations

            // ...or do it manually below. Example: https://github.com/AutoMapper/AutoMapper/wiki/Configuration
            // ...or see examples in Profiles directory.
        }
    }
}