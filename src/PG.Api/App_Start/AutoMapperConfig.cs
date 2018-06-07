using AutoMapper;
using System.Reflection;

namespace PG.Api
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(config =>
            {
                config.AddProfiles(Assembly.GetExecutingAssembly());
            });
        }
    }
}