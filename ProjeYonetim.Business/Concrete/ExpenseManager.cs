using ProjeYonetim.Business.Abstract;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjeYonetim.Business.Concrete
{
    public class ExpenseManager : IExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;
        public ExpenseManager(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }
        public async Task ExpenseCreateAsync(Expense entity)
        {
            await _expenseRepository.CreateAsync(entity);
        }
        public async Task ExpenseDeleteAsync(Expense entity)
        {
            await _expenseRepository.DeleteAsync(entity);
        }
        public async Task<List<Expense>> ExpenseGetAllAsync()
        {
            return await _expenseRepository.GetAllAsync();
        }
        public async Task<Expense> ExpenseGetByIdAsync(int id)
        {
            return await _expenseRepository.GetByIdAsync(id);
        }
        public async Task ExpenseUpdateAsync(Expense entity)
        {
            await _expenseRepository.UpdateAsync(entity);
        }
    }
}
