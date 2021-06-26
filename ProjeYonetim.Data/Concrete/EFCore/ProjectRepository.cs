using Microsoft.EntityFrameworkCore;
using ProjeYonetim.Core.DataAccess.EFCore;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeYonetim.Data.Concrete.EFCore
{
    public class ProjectRepository : EFCoreRepository<Project, ProjeYonetimDbContext>, IProjectRepository
    {
        public async Task<List<Sales>> GetSalesListAsync()
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.Sales.ToListAsync();
            }
        }

        public async Task<List<Project>> GetProjectSalesListAsync()
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.Projects.Include(x => x.Sales).ToListAsync();
            }
        }

        public async Task<Project> GetProjectSalesAsync(int id)
        {
            using (var context = new ProjeYonetimDbContext())
            {
                return await context.Projects.Include(x => x.Sales).FirstOrDefaultAsync(y => y.Id == id);
            }
        }

        public async Task<decimal> GetProjectNetIncomeAsync(int projectId)
        {
            var employeeTotalSalary = 0m;
            var oneDaySalary = 0m;
            var dayOfWorked = 0;
            var expenses = 0m;

            using (var context = new ProjeYonetimDbContext())
            {
                var employeesId = context.EmployeeProjects.Where(m => m.ProjectId == projectId).Select(n => n.EmployeeId).ToList();

                foreach (var item in employeesId)
                    oneDaySalary += context.Employees.FirstOrDefault(m => m.Id == item).Salary / 30;
                TimeSpan timeSpan = context.Projects.FirstOrDefault(m => m.Id == projectId).EndDate - context.Projects.FirstOrDefault(m => m.Id == projectId).StartDate;
                dayOfWorked = timeSpan.Days;
                employeeTotalSalary = dayOfWorked * oneDaySalary;


                var expensesId = context.Expenses.Where(m => m.ProjectId == projectId).Select(n => n.Id).ToList();
                foreach (var item in expensesId)
                    expenses += context.Expenses.FirstOrDefault(m => m.Id == item).ExpenseAmount;

                var projectIncome = context.Sales.FirstOrDefault(m => m.Id == context.Projects.SingleOrDefault(n => n.Id == projectId).SalesId).Price;

                var projectNetIncome = Decimal.Round(projectIncome - (employeeTotalSalary + expenses), 2);
                return await Task.FromResult(projectNetIncome);
            }
        }
    }
}

