using ProjeYonetim.Business.Abstract;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjeYonetim.Business.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        private readonly IToDoListRepository _toDoListRepository;
        public ToDoListManager(IToDoListRepository toDoListRepository)
        {
            _toDoListRepository = toDoListRepository;
        }
        public async Task ToDoListCreateAsync(ToDoList entity)
        {
            await _toDoListRepository.CreateAsync(entity);
        }
        public async Task ToDoListDeleteAsync(ToDoList entity)
        {
            await _toDoListRepository.DeleteAsync(entity);
        }
        public async Task<List<ToDoList>> ToDoListGetAllAsync()
        {
            return await _toDoListRepository.GetAllAsync();
        }
        public async Task<ToDoList> ToDoListGetByIdAsync(int id)
        {
            return await _toDoListRepository.GetByIdAsync(id);
        }
        public async Task ToDoListUpdateAsync(ToDoList entity)
        {
            await _toDoListRepository.UpdateAsync(entity);
        }
    }
}
