using Domain.Product;

namespace Infrastructure.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>
        , IProductRepository
    {
        public ProductRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }

}