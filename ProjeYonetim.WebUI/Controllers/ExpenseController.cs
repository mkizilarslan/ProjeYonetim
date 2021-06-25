using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjeYonetim.Business.Abstract;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;
using System.Threading.Tasks;

namespace ProjeYonetim.WebUI.Controllers
{
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
            var expense = await _expenseRepository.GetExpenseProject(id);
            return View(expense);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var expenseList = await _expenseRepository.GetExpenseProjects();
            return View(expenseList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(_expenseRepository.GetProject().Result, "Id", "ProjectName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Expense expense)
        {
            if (ModelState.IsValid)
            {
                await _expenseService.Create(expense);
                return RedirectToAction(nameof(GetAll));
            }
            return View(expense);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var expense = _expenseService.GetById(id).Result;
            ViewData["ProjectId"] = new SelectList(_expenseRepository.GetProject().Result, "Id", "ProjectName");
            return View(expense);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Expense expense)
        {
            if (ModelState.IsValid)
            {
                await _expenseService.Update(expense);
                return RedirectToAction(nameof(GetAll));
            }
            return View(expense);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var expense = await _expenseRepository.GetExpenseProject(id);
            return View(expense);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Expense expense)
        {
            if (ModelState.IsValid)
            {
                await _expenseService.Delete(expense);
                return RedirectToAction(nameof(GetAll));
            }
            return View(expense);
        }
    }
}
