using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Product;
using Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API.Services
{
    public class ProductService :IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> AddAsync(Product product)
        {
              await _productRepository.AddAsync(product);
              return true;


        }

        public Task<bool> UpdateAsync(Product product)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Product>> GetAllAsync()
        {
            var userList = new List<Product>();
            var result = await _productRepository.GetAll();
            return result;
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}