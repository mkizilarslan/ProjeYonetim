using ProjeYonetim.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeYonetim.Business.Abstract
{
    public interface IEmployeeProjectService
    {
        Task<EmployeeProject> EPGetByIdAsync(int id);
        Task<List<EmployeeProject>> EPGetAllAsync();
        Task EPCreateAsync(EmployeeProject entity);
        Task EPUpdateAsync(EmployeeProject entity);
        Task EPDeleteAsync(EmployeeProject entity);
    }
}
