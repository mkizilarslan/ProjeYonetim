using ProjeYonetim.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeYonetim.Business.Abstract
{
    public interface IEmployeeService
    {
        Task<Employee> GetById(int id);
        Task<List<Employee>> GetAll();
        Task Create(Employee entity);
        Task Update(Employee entity);
        Task Delete(Employee entity);
    }
}
