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
        Task<Project> ProjectGetByIdAsync(int id);
        Task<List<Project>> ProjectGetAllAsync();
        Task ProjectCreateAsync(Project entity);
        Task ProjectUpdateAsync(Project entity);
        Task ProjectDeleteAsync(Project entity);
    }
}
