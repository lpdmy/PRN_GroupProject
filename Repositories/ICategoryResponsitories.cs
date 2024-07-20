using BusinessLogic;
using Microsoft.EntityFrameworkCore;

namespace Responsitories
{
    public interface ICategoryResponsitories
    {
        Task<IEnumerable<Category>> GetCategorys();
        Task AddCategory(Category category);

        Task UpdateCategory(Category category);

        Task DeleteCategory(int categoryId);

        Task<Category> GetCategoryById(int categoryId);
       
    }
}
