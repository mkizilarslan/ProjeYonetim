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
        Task<Employee> EmployeeGetByIdAsync(int id);
        Task<List<Employee>> EmployeeGetAllAsync();
        Task EmployeeCreateAsync(Employee entity);
        Task EmployeeUpdateAsync(Employee entity);
        Task EmployeeDeleteAsync(Employee entity);
    }
}
