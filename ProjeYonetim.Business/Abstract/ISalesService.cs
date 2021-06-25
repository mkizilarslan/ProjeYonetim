using ProjeYonetim.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeYonetim.Business.Abstract
{
    public interface ISalesService
    {
        Task<Sales> GetById(int id);
        Task<List<Sales>> GetAll();
        Task Create(Sales entity);
        Task Update(Sales entity);
        Task Delete(Sales entity);
    }
}
