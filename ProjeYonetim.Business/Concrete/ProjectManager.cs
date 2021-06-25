using ProjeYonetim.Business.Abstract;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjeYonetim.Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        private readonly IProjectRepository _projectDal;
        public ProjectManager(IProjectRepository projectDal)
        {
            _projectDal = projectDal;
        }
        public async Task ProjectCreateAsync(Project entity)
        {
            await _projectDal.CreateAsync(entity);
        }
        public async Task ProjectDeleteAsync(Project entity)
        {
            await _projectDal.DeleteAsync(entity);
        }
        public async Task<List<Project>> ProjectGetAllAsync()
        {
            return await _projectDal.GetAllAsync();
        }
        public async Task<Project> ProjectGetByIdAsync(int id)
        {
            return await _projectDal.GetByIdAsync(id);
        }
        public async Task ProjectUpdateAsync(Project entity)
        {
            await _projectDal.UpdateAsync(entity);
        }
    }
}
