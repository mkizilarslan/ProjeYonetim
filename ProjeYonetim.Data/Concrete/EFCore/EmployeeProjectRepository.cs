using ProjeYonetim.Core.DataAccess.EFCore;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;

namespace ProjeYonetim.Data.Concrete.EFCore
{
    public class EmployeeProjectRepository : EFCoreRepository<EmployeeProject, ProjeYonetimDbContext>, IEmployeeProjectRepository
    {
    }
}
