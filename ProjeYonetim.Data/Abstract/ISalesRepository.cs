using Microsoft.EntityFrameworkCore.Query;
using ProjeYonetim.Core.DataAccess;
using ProjeYonetim.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjeYonetim.Data.Abstract
{
    public interface ISalesRepository : IRepository<Sales>
    {
        Task<List<Employee>> GetDepartmentAsync();
        Task<List<Sales>> GetSalesEmployeesAsync();
        Task<Sales> GetSalesEmployeeAsync(int id);
    }
}
