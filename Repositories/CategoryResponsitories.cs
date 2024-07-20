using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsitories
{
    public class CategoryResponsitories : ICategoryResponsitories
    {
        public async Task AddCategory(Category category)
        {
          await  CategoryDao.Instance.AddCategory(category);
        }

        public async Task DeleteCategory(int categoryId)
        {
            await CategoryDao.Instance.DeleteCategory(categoryId);
        }

        public async Task<Category> GetCategoryById(int categoryId)
        {
           return await CategoryDao.Instance.GetCategoryById(categoryId);
        }

        public async Task<IEnumerable<Category>> GetCategorys()
        { 
         return await CategoryDao.Instance.GetCategories();
        }

        public async Task UpdateCategory(Category category)
        {
            await CategoryDao.Instance.UpdateCategory(category);
        }
    }
}
