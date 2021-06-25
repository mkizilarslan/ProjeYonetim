using ProjeYonetim.Core.DataAccess.EFCore;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;

namespace ProjeYonetim.Data.Concrete.EFCore
{
    public class EmployeeRepository : EFCoreRepository<Employee, ProjeYonetimDbContext>, IEmployeeRepository
    {
    }
}
