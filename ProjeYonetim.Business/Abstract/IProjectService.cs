using ProjeYonetim.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeYonetim.Business.Abstract
{
    public interface IProjectService
    {
        Task<Project> GetById(int id);
        Task<List<Project>> GetAll();
        Task Create(Project entity);
        Task Update(Project entity);
        Task Delete(Project entity);
    }
}
