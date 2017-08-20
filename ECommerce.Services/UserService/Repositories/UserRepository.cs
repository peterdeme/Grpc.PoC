using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Grpc.Core;
using static ECommerce.Contracts.UserService;
using ECommerce.Contracts;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using ECommerce.Services.UserService.DbContext;

namespace ECommerce.Services.UserService.Repositories
{
    public class UserRepository : UserServiceBase
    {
        private IServiceProvider _serviceProvider;
        private readonly IMapper _mapper;

        public UserRepository(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _mapper = serviceProvider.GetRequiredService<IMapper>();
        }

        public override async Task<GetUserResponse> GetUserById(GetUserRequest request, ServerCallContext context)
        {
            var dbContext = _serviceProvider.GetRequiredService<UserDbContext>();

            var user = await dbContext
                        .Users
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.Id == request.UserId)
                        .ConfigureAwait(false);

            if (user == null)
                return new GetUserResponse { IsFound = false };

            return _mapper.Map<GetUserResponse>(user);
        }
    }
}
