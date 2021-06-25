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
        public async Task Create(ToDoList entity)
        {
            await _toDoListRepository.Create(entity);
        }
        public async Task Delete(ToDoList entity)
        {
            await _toDoListRepository.Delete(entity);
        }
        public async Task<List<ToDoList>> GetAll()
        {
            return await _toDoListRepository.GetAll();
        }
        public async Task<ToDoList> GetById(int id)
        {
            return await _toDoListRepository.GetById(id);
        }
        public async Task Update(ToDoList entity)
        {
            await _toDoListRepository.Update(entity);
        }
    }
}
