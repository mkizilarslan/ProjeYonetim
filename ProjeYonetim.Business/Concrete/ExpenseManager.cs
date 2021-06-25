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
        public async Task Create(Expense entity)
        {
            await _expenseRepository.Create(entity);
        }
        public async Task Delete(Expense entity)
        {
            await _expenseRepository.Delete(entity);
        }
        public async Task<List<Expense>> GetAll()
        {
            return await _expenseRepository.GetAll();
        }
        public async Task<Expense> GetById(int id)
        {
            return await _expenseRepository.GetById(id);
        }
        public async Task Update(Expense entity)
        {
            await _expenseRepository.Update(entity);
        }
    }
}
