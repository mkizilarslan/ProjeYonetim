using ProjeYonetim.Business.Abstract;
using ProjeYonetim.Data.Abstract;
using ProjeYonetim.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjeYonetim.Business.Concrete
{
    public class SalesManager : ISalesService
    {
        private readonly ISalesRepository _salesRepository;
        public SalesManager(ISalesRepository salesRepository)
        {
            _salesRepository = salesRepository;
        }
        public async Task Create(Sales entity)
        {
            await _salesRepository.Create(entity);
        }
        public async Task Delete(Sales entity)
        {
            await _salesRepository.Delete(entity);
        }
        public async Task<List<Sales>> GetAll()
        {
            return await _salesRepository.GetAll();
        }
        public async Task<Sales> GetById(int id)
        {
            return await _salesRepository.GetById(id);
        }
        public async Task Update(Sales entity)
        {
            await _salesRepository.Update(entity);
        }
    }
}
