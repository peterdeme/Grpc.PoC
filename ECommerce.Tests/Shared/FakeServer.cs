using ECommerce.Contracts;
using ECommerce.Services.ProductService.Repositories;
using ECommerce.Services.UserService.Repositories;
using Grpc.Core;
using System;

namespace ECommerce.Tests.Shared
{
    public class FakeServer
    {
        public const int FakeServerPort = 5495;
        private static Server _server;
        private static bool _started = false;

        public static void StartServer(IServiceProvider serviceProvider)
        {
            if (_started)
                return;

            _server = new Server
            {
                Services = {
                    ECommerce.Contracts.UserService.BindService(new UserRepository(serviceProvider) ),
                    ECommerce.Contracts.ProductService.BindService(new ProductRepository(serviceProvider))
                },
                Ports = { { "0.0.0.0", FakeServerPort, ServerCredentials.Insecure } }
            };

            _server.Start();

            _started = true;
        }

        public static void StopServer() => _server.ShutdownAsync().Wait();
    }
}
