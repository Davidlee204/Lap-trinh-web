using Microsoft.EntityFrameworkCore;
using WebXeXin.DataAccess;
using WebXeXin.Models;

namespace WebXeXin.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task AddAsync(Category category);
        Task UpdateAsync(Category category);
        Task DeleteAsync(int id);
    }
    
}
