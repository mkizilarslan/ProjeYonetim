using ProjeYonetim.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeYonetim.Business.Abstract
{
    public interface IExpenseService
    {
        Task<Expense> GetById(int id);
        Task<List<Expense>> GetAll();
        Task Create(Expense entity);
        Task Update(Expense entity);
        Task Delete(Expense entity);
    }
}
