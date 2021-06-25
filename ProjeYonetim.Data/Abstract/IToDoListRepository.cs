using ProjeYonetim.Core.DataAccess;
using ProjeYonetim.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjeYonetim.Data.Abstract
{
    public interface IToDoListRepository : IRepository<ToDoList>
    {
        Task<List<Project>> GetProject();
        Task<List<Employee>> GetEmployee();
        Task<List<ToDoList>> GetToDoListProjectAndEmployees();
        Task<ToDoList> GetToDoListProjectAndEmployee(int id);
        Task AddEmployeeToProjectAsync(int employeeId, int projectId);
        Task DeleteEmployeeToProjectAsync(int employeeId, int projectId);

    }
}
