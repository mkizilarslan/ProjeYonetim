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
        public async Task Create(Employee entity)
        {
            await _employeeRepository.Create(entity);
        }
        public async Task Delete(Employee entity)
        {
            await _employeeRepository.Delete(entity);
        }
        public async Task<List<Employee>> GetAll()
        {
            return await _employeeRepository.GetAll();
        }
        public async Task<Employee> GetById(int id)
        {
            return await _employeeRepository.GetById(id);
        }
        public async Task Update(Employee entity)
        {
            await _employeeRepository.Update(entity);
        }
    }
}
