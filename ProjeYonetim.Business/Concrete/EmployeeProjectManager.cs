using ProjeYonetim.Business.Abstract;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjeYonetim.Business.Concrete
{
    public class EmployeeProjectManager : IEmployeeProjectService
    {
        private readonly IEmployeeProjectRepository _employeeProjectRepository;
        public EmployeeProjectManager(IEmployeeProjectRepository employeeProjectRepository)
        {
            _employeeProjectRepository = employeeProjectRepository;
        }
        public async Task EPCreateAsync(EmployeeProject entity)
        {
            await _employeeProjectRepository.CreateAsync(entity);
        }
        public async Task EPDeleteAsync(EmployeeProject entity)
        {
            await _employeeProjectRepository.DeleteAsync(entity);
        }
        public async Task<List<EmployeeProject>> EPGetAllAsync()
        {
            return await _employeeProjectRepository.GetAllAsync();
        }
        public async Task<EmployeeProject> EPGetByIdAsync(int id)
        {
            return await _employeeProjectRepository.GetByIdAsync(id);
        }
        public async Task EPUpdateAsync(EmployeeProject entity)
        {
            await _employeeProjectRepository.UpdateAsync(entity);
        }
    }
}
