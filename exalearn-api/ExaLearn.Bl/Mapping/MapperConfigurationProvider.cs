using AutoMapper;
using AutoMapper.Configuration;

namespace ExaLearn.Bl.Mapping
{
    public static class MapperConfigurationProvider
    {
        public static MapperConfiguration GetConfig()
        {
            var cfg = new MapperConfigurationExpression();
            cfg.AddProfile<AudioProfile>();
            cfg.AddProfile<UserProfile>();
            cfg.AddProfile<UserAnswerProfile>();
            cfg.AddProfile<HistoryProfile>();

            var config = new MapperConfiguration(cfg);
            config.AssertConfigurationIsValid();

            return config;
        }
    }
}
