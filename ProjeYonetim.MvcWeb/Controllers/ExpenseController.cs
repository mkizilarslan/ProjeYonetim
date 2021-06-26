using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjeYonetim.Business.Abstract;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;
using System.Threading.Tasks;

namespace ProjeYonetim.Web.Controllers
{
    [Authorize(Roles = "Admin,Accounting")]
    public class ExpenseController : Controller
    {
        private readonly IExpenseService _expenseService;
        private readonly IExpenseRepository _expenseRepository;
        public ExpenseController(IExpenseService expenseService, IExpenseRepository expenseRepository)
        {
            _expenseService = expenseService;
            _expenseRepository = expenseRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var expense = await _expenseRepository.GetExpenseProjectAsync(id);
            return View(expense);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var expenseList = await _expenseRepository.GetExpenseProjectsAsync();
            return View(expenseList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(_expenseRepository.GetProjectAsync().Result, "Id", "ProjectName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Expense expense)
        {
            if (ModelState.IsValid)
            {
                await _expenseService.ExpenseCreateAsync(expense);
                return RedirectToAction(nameof(GetAll));
            }
            return View(expense);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var expense = _expenseService.ExpenseGetByIdAsync(id).Result;
            ViewData["ProjectId"] = new SelectList(_expenseRepository.GetProjectAsync().Result, "Id", "ProjectName");
            return View(expense);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Expense expense)
        {
            if (ModelState.IsValid)
            {
                await _expenseService.ExpenseUpdateAsync(expense);
                return RedirectToAction(nameof(GetAll));
            }
            return View(expense);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var expense = await _expenseRepository.GetExpenseProjectAsync(id);
            return View(expense);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Expense expense)
        {
            if (ModelState.IsValid)
            {
                await _expenseService.ExpenseDeleteAsync(expense);
                return RedirectToAction(nameof(GetAll));
            }
            return View(expense);
        }
    }
}
