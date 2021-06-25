using Microsoft.AspNetCore.Mvc;
using ProjeYonetim.Business.Abstract;
using ProjeYonetim.Entities;
using System.Threading.Tasks;

namespace ProjeYonetim.WebUI.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var project = await _projectService.ProjectGetByIdAsync(id);
            return View(project);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var projectList = await _projectService.ProjectGetAllAsync();
            return View(projectList);
        }

        [HttpGet]
        public IActionResult Create()
        {
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
        public IActionResult Delete(int id)
        {
            var project = _projectService.ProjectGetByIdAsync(id).Result;
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
