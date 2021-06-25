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
        Task<Sales> SalesGetByIdAsync(int id);
        Task<List<Sales>> SalesGetAllAsync();
        Task SalesCreateAsync(Sales entity);
        Task SalesUpdateAsync(Sales entity);
        Task SalesDeleteAsync(Sales entity);
    }
}
