using ProjeYonetim.Core.DataAccess;
using ProjeYonetim.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjeYonetim.Data.Abstract
{
    public interface IProjectRepository : IRepository<Project>
    {
        Task<List<Sales>> GetSalesListAsync();
        Task<List<Project>> GetProjectSalesListAsync();
        Task<Project> GetProjectSalesAsync(int id);
        Task<decimal> GetProjectNetIncomeAsync(int projectId);
    }
}
