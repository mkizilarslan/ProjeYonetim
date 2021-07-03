using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjeYonetim.Business.Abstract;
using ProjeYonetim.Entities;
using System.Threading.Tasks;

namespace ProjeYonetim.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployeeService _employeeService;
        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await _employeeService.EmployeeGetByIdAsync(id);
            return View(employee);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var employeeList = await _employeeService.EmployeeGetAllAsync();
            return View(employeeList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                await _employeeService.EmployeeCreateAsync(employee);
                _logger.LogInformation($"{employee.FullName} isimli personel oluşturuldu.");
                return RedirectToAction(nameof(GetAll));
            }
            return View(employee);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var employee = _employeeService.EmployeeGetByIdAsync(id).Result;
            return View(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Employee employee)
        {
            if (ModelState.IsValid)
            {
                await _employeeService.EmployeeUpdateAsync(employee);
                _logger.LogInformation($"{employee.FullName} isimli personel güncellendi.");
                return RedirectToAction(nameof(GetAll));
            }
            return View(employee);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = _employeeService.EmployeeGetByIdAsync(id).Result;
            return View(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Employee employee)
        {
            if (ModelState.IsValid)
            {
                await _employeeService.EmployeeDeleteAsync(employee);
                _logger.LogInformation($"{employee.FullName} isimli personel silindi.");
                return RedirectToAction(nameof(GetAll));
            }
            return View(employee);
        }

    }
}
