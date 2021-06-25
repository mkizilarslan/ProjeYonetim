using Microsoft.AspNetCore.Mvc;
using ProjeYonetim.Business.Abstract;
using ProjeYonetim.Entities;
using System.Threading.Tasks;

namespace ProjeYonetim.WebUI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await _employeeService.GetById(id);
            return View(employee);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employeeList = await _employeeService.GetAll();
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
                await _employeeService.Create(employee);
                return RedirectToAction(nameof(GetAll));
            }
            return View(employee);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var employee = _employeeService.GetById(id).Result;
            return View(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Employee employee)
        {
            if (ModelState.IsValid)
            {
                await _employeeService.Update(employee);
                return RedirectToAction(nameof(GetAll));
            }
            return View(employee);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = _employeeService.GetById(id).Result;
            return View(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Employee employee)
        {
            if (ModelState.IsValid)
            {
                await _employeeService.Delete(employee);
                return RedirectToAction(nameof(GetAll));
            }
            return View(employee);
        }

    }
}
