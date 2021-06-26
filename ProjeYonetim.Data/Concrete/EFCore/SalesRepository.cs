using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using ProjeYonetim.Core.DataAccess.EFCore;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeYonetim.Data.Concrete.EFCore
{
    public class SalesRepository : EFCoreRepository<Sales, ProjeYonetimDbContext>, ISalesRepository
    {
        public async Task<List<Employee>> GetDepartmentAsync()
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.Employees.Where(x => x.Department == Entities.Constant.Department.Satış && x.IsActive == true).ToListAsync();
            }
        }

        public async Task<List<Sales>> GetSalesEmployeesAsync()
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.Sales.Include(x => x.Employee).ToListAsync();
            }
        }

        public async Task<Sales> GetSalesEmployeeAsync(int id)
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.Sales.Include(x => x.Employee).FirstOrDefaultAsync(y => y.Id == id);
            }
        }
    }
}

