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
        Task<EmployeeProject> GetById(int id);
        Task<List<EmployeeProject>> GetAll();
        Task Create(EmployeeProject entity);
        Task Update(EmployeeProject entity);
        Task Delete(EmployeeProject entity);
    }
}
