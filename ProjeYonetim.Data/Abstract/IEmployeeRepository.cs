using ProjeYonetim.Core.DataAccess;
using ProjeYonetim.Entities;

namespace ProjeYonetim.Data.Abstract
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        //Bu modele özel operasyonlar
    }
}
