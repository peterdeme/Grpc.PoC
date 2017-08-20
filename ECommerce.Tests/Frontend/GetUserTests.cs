using AutoMapper;
using ECommerce.Frontend.Connectors;
using ECommerce.Frontend.Controllers;
using ECommerce.Frontend.ViewModels;
using ECommerce.Tests.Shared;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System.Threading.Tasks;
using Xunit;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace ECommerce.Tests.Frontend
{
    public class GetUserTests
    {
        private readonly IServiceProvider _serviceProvider;

        public GetUserTests()
        {
            //_serviceProvider = ServiceProvider.GetServiceProvider(SeedData.PopulateDbContext);
            FakeServer.StartServer(_serviceProvider);
        }

        [Fact]
        public async Task GetUserAsync_Positive_Flow()
        {
            var backendAccessor = new FakeBackendAccessor();

            var homeController = new HomeController(backendAccessor, _serviceProvider.GetRequiredService<IMapper>());

            var response = await homeController.GetUserAsync(1);

            var viewResult = Assert.IsType<ViewResult>(response);

            var userViewModel = Assert.IsType<UserViewModel>(viewResult.Model);

            var firstUser = SeedData.Users.First();

            Assert.Equal(firstUser.Id, userViewModel.Id);
            Assert.Equal(firstUser.DateOfBirth, userViewModel.DateOfBirth);
            Assert.Equal(firstUser.FirstName, userViewModel.FirstName);
            Assert.Equal(firstUser.LastName, userViewModel.LastName);
        }
    }
}
