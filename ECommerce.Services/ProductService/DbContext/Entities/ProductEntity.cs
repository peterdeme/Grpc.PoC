using System.Collections.Generic;

namespace ECommerce.Services.ProductService.DbContext.Entities
{
    public class ProductEntity
    {
        public ProductEntity()
        {
            AddOns = new List<ProductEntity>();
        }

        public int Id { get; set; }
        public ProductFamily ProductFamily { get; set; }
        public string ProductName { get; set; }
        public List<ProductEntity> AddOns { get; set; }
    }
}
