﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjeYonetim.Business.Abstract;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;
using System.Threading.Tasks;

namespace ProjeYonetim.WebUI.Controllers
{
    public class ToDoListController : Controller
    {
        private readonly IToDoListService _toDoListService;
        private readonly IToDoListRepository _toDoListRepository;
        public ToDoListController(IToDoListService toDoListService, IToDoListRepository toDoListRepository)
        {
            _toDoListService = toDoListService;
            _toDoListRepository = toDoListRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var toDo = await _toDoListRepository.GetToDoListProjectAndEmployee(id);
            return View(toDo);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var toDoList = await _toDoListRepository.GetToDoListProjectAndEmployees();
            return View(toDoList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["EmployeeId"] = new SelectList(_toDoListRepository.GetEmployee().Result, "Id", "FullName");
            ViewData["ProjectId"] = new SelectList(_toDoListRepository.GetProject().Result, "Id", "ProjectName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ToDoList toDo)
        {
            if (ModelState.IsValid)
            {
                await _toDoListService.Create(toDo);
                return RedirectToAction(nameof(GetAll));
            }
            return View(toDo);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var toDo = _toDoListService.GetById(id).Result;
            ViewData["EmployeeId"] = new SelectList(_toDoListRepository.GetEmployee().Result, "Id", "FullName");
            ViewData["ProjectId"] = new SelectList(_toDoListRepository.GetProject().Result, "Id", "ProjectName");
            return View(toDo);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ToDoList toDo)
        {
            if (ModelState.IsValid)
            {
                await _toDoListService.Update(toDo);
                return RedirectToAction(nameof(GetAll));
            }
            return View(toDo);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var toDo = await _toDoListRepository.GetToDoListProjectAndEmployee(id);
            return View(toDo);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ToDoList toDo)
        {
            if (ModelState.IsValid)
            {
                await _toDoListService.Delete(toDo);
                return RedirectToAction(nameof(GetAll));
            }
            return View(toDo);
        }
    }
}