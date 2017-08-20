using AutoMapper;
using ECommerce.Contracts;
using ECommerce.Contracts.Extensions;
using ECommerce.Frontend.ViewModels;

namespace ECommerce.Frontend.AppStart
{
    public class AutoMapperConfig
    {
        public static void ConfigureMapper(IMapperConfigurationExpression config)
        {
            config.CreateMap<GetUserResponse, UserViewModel>()
                .ForMember(x => x.Id, conf => conf.MapFrom( x=> x.UserId))
                .ForMember(x => x.DateOfBirth, conf => conf.MapFrom(x => x.DateOfBirth.ToDateTime()));            
        }
    }
}
