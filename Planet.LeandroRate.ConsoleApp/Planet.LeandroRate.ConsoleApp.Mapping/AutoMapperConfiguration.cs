using AutoMapper;
using Planet.LeandroRate.ConsoleApp.Mapping.Profiles;

namespace Planet.LeandroRate.ConsoleApp.Mapping
{
    public static class AutoMapperConfiguration
    {
        public static MapperConfiguration _config;

        public static void Register()
        {
            _config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new TeslaDomainProfile());
            });
        }
    }
}