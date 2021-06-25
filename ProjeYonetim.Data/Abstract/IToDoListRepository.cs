using ProjeYonetim.Core.DataAccess;
using ProjeYonetim.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjeYonetim.Data.Abstract
{
    public interface IToDoListRepository : IRepository<ToDoList>
    {
        Task<List<Project>> GetProjectAsync();
        Task<List<Employee>> GetEmployeeAsync();
        Task<List<ToDoList>> GetToDoIncludeProAndEmpListAsync();
        Task<ToDoList> GetToDoProAndEmpAsync(int id);
        Task AddEmployeeToProjectAsync(int employeeId, int projectId);
        Task DeleteEmployeeToProjectAsync(int employeeId, int projectId);

    }
}
