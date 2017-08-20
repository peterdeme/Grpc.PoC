using ECommerce.Frontend.Connectors;
using static ECommerce.Contracts.UserService;
using ECommerce.Tests.Shared;
using Grpc.Core;
using ECommerce.Contracts;

namespace ECommerce.Tests.Frontend
{
    public class FakeBackendAccessor : IBackendAccessor
    {
        public Contracts.ProductService.ProductServiceClient GetProductService()
        {
            throw new System.NotImplementedException();
        }

        public UserServiceClient GetUserService()
        {
            var channel = new Channel("127.0.0.1", FakeServer.FakeServerPort, ChannelCredentials.Insecure);

            return new UserServiceClient(channel);
        }
    }
}
