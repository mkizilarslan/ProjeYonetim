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
        public async Task SalesCreateAsync(Sales entity)
        {
            await _salesRepository.CreateAsync(entity);
        }
        public async Task SalesDeleteAsync(Sales entity)
        {
            await _salesRepository.DeleteAsync(entity);
        }
        public async Task<List<Sales>> SalesGetAllAsync()
        {
            return await _salesRepository.GetAllAsync();
        }
        public async Task<Sales> SalesGetByIdAsync(int id)
        {
            return await _salesRepository.GetByIdAsync(id);
        }
        public async Task SalesUpdateAsync(Sales entity)
        {
            await _salesRepository.UpdateAsync(entity);
        }
    }
}
