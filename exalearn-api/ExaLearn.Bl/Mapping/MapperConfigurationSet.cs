using Microsoft.Extensions.DependencyInjection;

namespace ExaLearn.Bl.Mapping
{
    public static class MapperConfigurationSet
    {
        public static IServiceCollection AddMapper(this IServiceCollection serviceCollection)
        {
            var mapper = MapperConfigurationProvider.GetConfig().CreateMapper();
            return serviceCollection.AddSingleton(mapper);
        }
    }
}
