using static ECommerce.Contracts.ProductService;
using static ECommerce.Contracts.UserService;

namespace ECommerce.Frontend.Connectors
{
    public interface IBackendAccessor
    {
        UserServiceClient GetUserService();
        ProductServiceClient GetProductService();
    }
}
