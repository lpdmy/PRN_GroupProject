using BusinessLogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDao : SingletonBase<CategoryDao>
    {
       

        public async Task<IEnumerable<Category>> GetCategories()
        {
            try
            {
                return await _context.Categories.AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving categories.", ex);
            }
        }

        public async Task AddCategory(Category category)
        {
            try
            {
                await _context.Categories.AddAsync(category);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Error adding category. Database update error.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding category.", ex);
            }
        }

        public async Task UpdateCategory(Category category)
        {
            try
            {
                _context.Categories.Update(category);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Error updating category. Database update error.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating category.", ex);
            }
        }

        public async Task DeleteCategory(int categoryId)
        {
            try
            {
                var category = await _context.Categories.FindAsync(categoryId);
                if (category != null)
                {
                    _context.Categories.Remove(category);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    throw new InvalidOperationException("Category not found.");
                }
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Error deleting category. Database update error.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting category.", ex);
            }
        }

        public async Task<Category> GetCategoryById(int categoryId)
        {
            try
            {
                return await _context.Categories.AsNoTracking().FirstOrDefaultAsync(c => c.CategoryId == categoryId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving category with ID {categoryId}. {ex.Message}");
            }
        }
    }
}
