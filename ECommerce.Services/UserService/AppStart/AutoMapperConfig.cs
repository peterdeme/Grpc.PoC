using AutoMapper;
using ECommerce.Contracts;
using ECommerce.Contracts.Extensions;
using ECommerce.Services.UserService.DbContext.Entities;

namespace ECommerce.Services.UserService.AppStart
{
    public class AutoMapperConfig
    {
        public static void ConfigureMapper(IMapperConfigurationExpression config)
        {
            config.CreateMap<UserEntity, GetUserResponse>()
                .ForMember(x => x.UserId, conf => conf.MapFrom(x => x.Id))
                .ForMember(x => x.DateOfBirth, conf => conf.MapFrom(x=> x.DateOfBirth.ToTimeStamp()))
                .AfterMap((user, userResponse) => userResponse.IsFound = true);
        }
    }
}
