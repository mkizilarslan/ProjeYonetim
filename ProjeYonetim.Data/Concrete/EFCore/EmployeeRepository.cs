using Microsoft.EntityFrameworkCore;
using ProjeYonetim.Core.DataAccess.EFCore;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeYonetim.Data.Concrete.EFCore
{
    public class EmployeeRepository : EFCoreRepository<Employee, ProjeYonetimDbContext>, IEmployeeRepository
    {
        public override async Task DeleteAsync(Employee entity)
        {
            using (var context = new ProjeYonetimDbContext())
            {
                entity.IsActive = false;
                context.Entry(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }

        public override async Task<List<Employee>> GetAllAsync()
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.Employees.Where(x => x.IsActive == true).ToListAsync();
            }
        }        
    }
}
