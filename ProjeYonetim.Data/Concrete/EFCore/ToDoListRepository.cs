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

        public async Task<List<Project>> GetProjectAsync()
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.Projects.ToListAsync();
            }
        }

        public async Task<List<Employee>> GetEmployeeAsync()
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.Employees.Where(x => x.Department == Entities.Constant.Department.Yazılım && x.IsActive == true).ToListAsync();
            }
        }

        public async Task<List<ToDoList>> GetToDoIncludeProAndEmpListAsync()
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.ToDoLists.Include(x => x.Project).Include(y => y.Employee).ToListAsync();
            }
        }

        public async Task<ToDoList> GetToDoProAndEmpAsync(int id)
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

        public override async Task DeleteAsync(ToDoList entity)
        {
            using (var context = new ProjeYonetimDbContext())
            {
                context.Set<ToDoList>().Remove(entity);
                await DeleteEmployeeToProjectAsync(entity.EmployeeId, entity.ProjectId);
                await context.SaveChangesAsync();
            }
        }

        public override async Task CreateAsync(ToDoList entity)
        {

            using (var context = new ProjeYonetimDbContext())
            {
                context.Set<ToDoList>().Add(entity);
                await AddEmployeeToProjectAsync(entity.EmployeeId, entity.ProjectId);
                await context.SaveChangesAsync();
            }
        }

    }
}
