using ECommerce.Contracts.Configuration;
using Grpc.Core;
using System;
using System.Diagnostics;
using System.Threading;
using static ECommerce.Contracts.ProductService;
using static ECommerce.Contracts.UserService;

namespace ECommerce.Frontend.Connectors
{
    public class BackendAccessor : IBackendAccessor
    {
        private static UserServiceClient UserServiceClient = null;
        private static ProductServiceClient ProductServiceClient = null;

        public UserServiceClient GetUserService()
        {
            if (UserServiceClient != null)
                return UserServiceClient;

            var stopWatch = Stopwatch.StartNew();

            Exception exception = null;

            while (stopWatch.Elapsed.TotalSeconds < 10)
            {
                try
                {
                    var channel = new Channel("127.0.0.1", SharedConstants.GRPC.UserServiceBackendPortNumber, ChannelCredentials.Insecure);

                    UserServiceClient = new UserServiceClient(channel);

                    return UserServiceClient;
                }
                catch (Exception ex)
                {
                    exception = ex;
                }

                Thread.Sleep(500);
            }

            throw new Exception($"Unable to connect to UserService backend: {exception}");
        }

        public ProductServiceClient GetProductService()
        {
            if (ProductServiceClient != null)
                return ProductServiceClient;

            var stopWatch = Stopwatch.StartNew();

            Exception exception = null;

            while (stopWatch.Elapsed.TotalSeconds < 10)
            {
                try
                {
                    var channel = new Channel("127.0.0.1", SharedConstants.GRPC.ProductServiceBackendPortNumber, ChannelCredentials.Insecure);

                    ProductServiceClient = new ProductServiceClient(channel);

                    return ProductServiceClient;
                }
                catch (Exception ex)
                {
                    exception = ex;
                }

                Thread.Sleep(500);
            }

            throw new Exception($"Unable to connect to ProductService backend: {exception}");
        }
    }
}
