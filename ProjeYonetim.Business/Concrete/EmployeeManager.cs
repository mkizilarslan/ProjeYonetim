using ProjeYonetim.Business.Abstract;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjeYonetim.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeManager(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task EmployeeCreateAsync(Employee entity)
        {
            entity.IsActive = true;
            await _employeeRepository.CreateAsync(entity);
        }
        public async Task EmployeeDeleteAsync(Employee entity)
        {
            await _employeeRepository.DeleteAsync(entity);
        }
        public async Task<List<Employee>> EmployeeGetAllAsync()
        {
            return await _employeeRepository.GetAllAsync();
        }
        public async Task<Employee> EmployeeGetByIdAsync(int id)
        {
            return await _employeeRepository.GetByIdAsync(id);
        }
        public async Task EmployeeUpdateAsync(Employee entity)
        {
            entity.IsActive = true;
            await _employeeRepository.UpdateAsync(entity);
        }
    }
}
