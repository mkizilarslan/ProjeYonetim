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
        public async Task Create(Project entity)
        {
            await _projectDal.Create(entity);
        }
        public async Task Delete(Project entity)
        {
            await _projectDal.Delete(entity);
        }
        public async Task<List<Project>> GetAll()
        {
            return await _projectDal.GetAll();
        }
        public async Task<Project> GetById(int id)
        {
            return await _projectDal.GetById(id);
        }
        public async Task Update(Project entity)
        {
            await _projectDal.Update(entity);
        }
    }
}
