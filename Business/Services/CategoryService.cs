using Data.Models;
using Data.Repositories;

namespace Business.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> GetAllCategories() => _categoryRepository.GetAll();

        public Category GetCategoryById(int id) => _categoryRepository.GetById(id);

        public void CreateCategory(Category category)
        {

            _categoryRepository.Add(category);
        }

        public void UpdateCategory(Category category)
        {

            _categoryRepository.Update(category);
        }

        public void DeleteCategory(int id) => _categoryRepository.Delete(id);
    }
}
