using ProjeYonetim.Core.DataAccess;
using ProjeYonetim.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjeYonetim.Data.Abstract
{
    public interface IExpenseRepository : IRepository<Expense>
    {
        Task<List<Project>> GetProjectAsync();
        Task<List<Expense>> GetExpenseProjectsAsync();
        Task<Expense> GetExpenseProjectAsync(int id);
    }
}
