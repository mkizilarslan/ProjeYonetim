using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjeYonetim.Business.Abstract;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;
using System.Threading.Tasks;

namespace ProjeYonetim.WebUI.Controllers
{
    public class SalesController : Controller
    {
        private readonly ISalesService _salesService;
        private readonly ISalesRepository _salesRepository;
        public SalesController(ISalesService salesService, ISalesRepository salesRepository)
        {
            _salesService = salesService;
            _salesRepository = salesRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var sales = await _salesRepository.GetSalesEmployeeAsync(id);
            return View(sales);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var salesList = await _salesRepository.GetSalesEmployeesAsync();
            return View(salesList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["EmployeeId"] = new SelectList(_salesRepository.GetDepartmentAsync().Result, "Id", "FullName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Sales sales)
        {
            if (ModelState.IsValid)
            {
                await _salesService.SalesCreateAsync(sales);
                return RedirectToAction(nameof(GetAll));
            }
            return View(sales);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var sales = _salesService.SalesGetByIdAsync(id).Result;
            ViewData["EmployeeId"] = new SelectList(_salesRepository.GetDepartmentAsync().Result, "Id", "FullName");
            return View(sales);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Sales sales)
        {
            if (ModelState.IsValid)
            {
                await _salesService.SalesUpdateAsync(sales);
                return RedirectToAction(nameof(GetAll));
            }
            return View(sales);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var sales = await _salesRepository.GetSalesEmployeeAsync(id);
            return View(sales);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Sales sales)
        {
            if (ModelState.IsValid)
            {
                await _salesService.SalesDeleteAsync(sales);
                return RedirectToAction(nameof(GetAll));
            }
            return View(sales);
        }
    }
}
