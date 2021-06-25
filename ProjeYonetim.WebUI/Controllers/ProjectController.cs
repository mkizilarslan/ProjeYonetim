using Microsoft.AspNetCore.Mvc;
using ProjeYonetim.Business.Abstract;
using ProjeYonetim.Data.Abstract;
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
            var project = await _projectService.GetById(id);
            return View(project);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var projectList = await _projectService.GetAll();
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
                await _projectService.Create(project);
                return RedirectToAction(nameof(GetAll));
            }
            return View(project);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var project = _projectService.GetById(id).Result;
            return View(project);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Project project)
        {
            if (ModelState.IsValid)
            {
                await _projectService.Update(project);
                return RedirectToAction(nameof(GetAll));
            }
            return View(project);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var project = _projectService.GetById(id).Result;
            return View(project);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Project project)
        {
            if (ModelState.IsValid)
            {
                await _projectService.Delete(project);
                return RedirectToAction(nameof(GetAll));
            }
            return View(project);
        }
    }
}
