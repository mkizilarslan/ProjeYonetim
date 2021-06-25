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
        Task<Expense> ExpenseGetByIdAsync(int id);
        Task<List<Expense>> ExpenseGetAllAsync();
        Task ExpenseCreateAsync(Expense entity);
        Task ExpenseUpdateAsync(Expense entity);
        Task ExpenseDeleteAsync(Expense entity);
    }
}
