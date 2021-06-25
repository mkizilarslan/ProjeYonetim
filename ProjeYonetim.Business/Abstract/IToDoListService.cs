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
        Task<ToDoList> ToDoListGetByIdAsync(int id);
        Task<List<ToDoList>> ToDoListGetAllAsync();
        Task ToDoListCreateAsync(ToDoList entity);
        Task ToDoListUpdateAsync(ToDoList entity);
        Task ToDoListDeleteAsync(ToDoList entity);
    }
}
