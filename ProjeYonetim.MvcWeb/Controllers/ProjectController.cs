using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjeYonetim.Business.Abstract;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;
using System.Threading.Tasks;

namespace ProjeYonetim.Web.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;
        private readonly IProjectRepository _projectRepository;
        public ProjectController(IProjectService projectService, IProjectRepository projectRepository)
        {
            _projectService = projectService;
            _projectRepository = projectRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            ViewData["NetIncome"] = _projectRepository.GetProjectNetIncomeAsync(id).Result;
            var project = await _projectRepository.GetProjectSalesAsync(id);
            return View(project);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var projectList = await _projectRepository.GetProjectSalesListAsync();
            return View(projectList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["SalesId"] = new SelectList(_projectRepository.GetSalesListAsync().Result, "Id", "SalesName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Project project)
        {
            if (ModelState.IsValid)
            {
                await _projectService.ProjectCreateAsync(project);
                return RedirectToAction(nameof(GetAll));
            }
            return View(project);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var project = _projectService.ProjectGetByIdAsync(id).Result;
            ViewData["SalesId"] = new SelectList(_projectRepository.GetSalesListAsync().Result, "Id", "SalesName");
            return View(project);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Project project)
        {
            if (ModelState.IsValid)
            {
                await _projectService.ProjectUpdateAsync(project);
                return RedirectToAction(nameof(GetAll));
            }
            return View(project);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var project = await _projectRepository.GetProjectSalesAsync(id);
            return View(project);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Project project)
        {
            if (ModelState.IsValid)
            {
                await _projectService.ProjectDeleteAsync(project);
                return RedirectToAction(nameof(GetAll));
            }
            return View(project);
        }
    }
}
