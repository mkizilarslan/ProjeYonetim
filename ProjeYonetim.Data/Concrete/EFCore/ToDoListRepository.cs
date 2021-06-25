using Microsoft.EntityFrameworkCore;
using ProjeYonetim.Core.DataAccess.EFCore;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeYonetim.Data.Concrete.EFCore
{
    public class ToDoListRepository : EFCoreRepository<ToDoList, ProjeYonetimDbContext>, IToDoListRepository
    {

        public async Task<List<Project>> GetProject()
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.Projects.ToListAsync();
            }
        }

        public async Task<List<Employee>> GetEmployee()
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.Employees.Where(x => x.Department == Entities.Constant.Department.Yazılım).ToListAsync();
            }
        }

        public async Task<List<ToDoList>> GetToDoListProjectAndEmployees()
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.ToDoLists.Include(x => x.Project).Include(y => y.Employee).ToListAsync();
            }
        }

        public async Task<ToDoList> GetToDoListProjectAndEmployee(int id)
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.ToDoLists.Include(x => x.Project).Include(y => y.Employee).FirstOrDefaultAsync(y => y.Id == id);
            }
        }

        public async Task AddEmployeeToProjectAsync(int employeeId, int projectId)
        {
            using (var context = new ProjeYonetimDbContext())
            {
                if (!context.EmployeeProjects.Any(m => m.EmployeeId == employeeId && m.ProjectId == projectId))
                {
                    var employeeProject = new EmployeeProject
                    {
                        EmployeeId = employeeId,
                        ProjectId = projectId
                    };
                    context.EmployeeProjects.Add(employeeProject);
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task DeleteEmployeeToProjectAsync(int employeeId, int projectId)
        {
            using (var context = new ProjeYonetimDbContext())
            {
                var todoCount = context.ToDoLists.Where(m => m.ProjectId == projectId && m.EmployeeId == employeeId).ToList();

                if (todoCount.Count <= 1)
                {
                    var ep = context.EmployeeProjects.FirstOrDefault(m => m.ProjectId == projectId && m.EmployeeId == employeeId);
                    context.EmployeeProjects.Remove(ep);
                    await context.SaveChangesAsync();
                }
            }
        }

        public override async Task Delete(ToDoList entity)
        {
            using (var context = new ProjeYonetimDbContext())
            {
                context.Set<ToDoList>().Remove(entity);
                await DeleteEmployeeToProjectAsync(entity.EmployeeId, entity.ProjectId);
                await context.SaveChangesAsync();
            }
        }

    }
}
