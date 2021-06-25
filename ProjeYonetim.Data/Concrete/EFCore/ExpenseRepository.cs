using Microsoft.EntityFrameworkCore;
using ProjeYonetim.Core.DataAccess.EFCore;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeYonetim.Data.Concrete.EFCore
{
    public class ExpenseRepository : EFCoreRepository<Expense, ProjeYonetimDbContext>, IExpenseRepository
    {
        public async Task<List<Project>> GetProjectAsync()
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.Projects.ToListAsync();
            }
        }

        public async Task<List<Expense>> GetExpenseProjectsAsync()
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.Expenses.Include(x => x.Project).ToListAsync();
            }
        }

        public async Task<Expense> GetExpenseProjectAsync(int id)
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.Expenses.Include(x => x.Project).FirstOrDefaultAsync(y => y.Id == id);
            }
        }
    }
}
