using Data.Models;
using Data.Repositories;

namespace Business.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts() => _productRepository.GetAll();

        public Product GetProductById(int id) => _productRepository.GetById(id);

        public void CreateProduct(Product product)
        {
            
            _productRepository.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            
            _productRepository.Update(product);
        }

        public void DeleteProduct(int id) => _productRepository.Delete(id);
    }
}
