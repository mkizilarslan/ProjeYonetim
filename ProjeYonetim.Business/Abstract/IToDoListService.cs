using ProjeYonetim.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeYonetim.Business.Abstract
{
    public interface IToDoListService
    {
        Task<ToDoList> GetById(int id);
        Task<List<ToDoList>> GetAll();
        Task Create(ToDoList entity);
        Task Update(ToDoList entity);
        Task Delete(ToDoList entity);
    }
}
