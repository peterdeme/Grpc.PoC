using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ECommerce.Frontend.Connectors;
using ECommerce.Contracts;
using ECommerce.Frontend.ViewModels;
using static ECommerce.Contracts.UserService;


namespace ECommerce.Frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserServiceClient _userService;
        private readonly ProductService.ProductServiceClient _productService;
        private readonly IMapper _mapper;

        public HomeController(IBackendAccessor backendAccessor, IMapper mapper)
        {
            _userService = backendAccessor.GetUserService();
            _productService = backendAccessor.GetProductService();
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public async Task<IActionResult> GetUserAsync(long id)
        {
            var user = await _userService.GetUserByIdAsync(new GetUserRequest { UserId = id });

            return View("ShowUser", _mapper.Map<UserViewModel>(user));
        }
    }
}
