using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Product;

namespace API.Services
{
    public interface IProductService
    {
    Task<bool> AddAsync(Product product);
    Task<bool> UpdateAsync(Product product);
    Task<List<Product>> GetAllAsync();
    Task<Product> GetByIdAsync(int id); 
    Task<bool> DeleteAsync(int id);

    }
}