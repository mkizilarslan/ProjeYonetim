﻿using Microsoft.EntityFrameworkCore;
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
    }
}