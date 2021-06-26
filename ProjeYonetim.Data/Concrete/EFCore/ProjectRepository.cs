using Microsoft.EntityFrameworkCore;
using ProjeYonetim.Core.DataAccess.EFCore;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeYonetim.Data.Concrete.EFCore
{
    public class ProjectRepository : EFCoreRepository<Project, ProjeYonetimDbContext>, IProjectRepository
    {
        public async Task<List<Sales>> GetSalesListAsync()
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.Sales.ToListAsync();
            }
        }

        public async Task<List<Project>> GetProjectSalesListAsync()
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.Projects.Include(x => x.Sales).ToListAsync();
            }
        }

        public async Task<Project> GetProjectSalesAsync(int id)
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.Projects.Include(x => x.Sales).FirstOrDefaultAsync(y => y.Id == id);
            }
        }
    }
}

