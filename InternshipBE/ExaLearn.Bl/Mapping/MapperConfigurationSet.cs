using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Mapping
{
    public static class MapperConfigurationSet
    {
        public static IServiceCollection AddMapper(IServiceCollection serviceCollection)
        {
            var mapper = MapperConfigurationProvider.GetConfig().CreateMapper();
            return serviceCollection.AddSingleton(mapper);
        }
    }
}
