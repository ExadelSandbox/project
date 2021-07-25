using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace ExaLearn.Bl.Mapping
{
    public static class MapperConfigurationSet
    {
        private static IMapper _mapper;

        public static IServiceCollection AddMapper(this IServiceCollection serviceCollection)
        {
            _mapper = MapperConfigurationProvider.GetConfig().CreateMapper();
            return serviceCollection.AddSingleton(_mapper);
        }

        public static TDestination Map<TSource, TDestination>(this TDestination destination, TSource source)
        {
            return _mapper.Map(source, destination);
        }
    }
}
