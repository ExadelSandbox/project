using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace ExaLearn.Bl.Mapping
{
    public static class MapperConfigurationSet
    {
        private static readonly IMapper _mapper = MapperConfigurationProvider.GetConfig().CreateMapper();

        public static IServiceCollection AddMapper(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddSingleton(_mapper);
        }

        public static TDestination Map<TSource, TDestination>(this TDestination destination, TSource source)
        {
            return _mapper.Map(source, destination);
        }
    }
}
