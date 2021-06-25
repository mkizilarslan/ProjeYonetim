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
        public async Task Create(EmployeeProject entity)
        {
            await _employeeProjectRepository.Create(entity);
        }
        public async Task Delete(EmployeeProject entity)
        {
            await _employeeProjectRepository.Delete(entity);
        }
        public async Task<List<EmployeeProject>> GetAll()
        {
            return await _employeeProjectRepository.GetAll();
        }
        public async Task<EmployeeProject> GetById(int id)
        {
            return await _employeeProjectRepository.GetById(id);
        }
        public async Task Update(EmployeeProject entity)
        {
            await _employeeProjectRepository.Update(entity);
        }
    }
}
