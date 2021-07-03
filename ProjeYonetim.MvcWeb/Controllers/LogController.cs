using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjeYonetim.Data;
using ProjeYonetim.Entities;
using ProjeYonetim.MvcWeb.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeYonetim.MvcWeb.Controllers
{
    public class LogController : Controller
    {
        private readonly ProjeYonetimDbContext _context;
        public LogController(ProjeYonetimDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _context.Logs.ToListAsync();
            List<Logs> logList = new List<Logs>();
            foreach (var item in result)
            {
                if (item.Message.Length >= 40)
                {
                    var message = item.Message.Substring(0, 43) + "...";
                    var messageTemp = item.Message.Substring(0, 43) + "...";
                    logList.Add(new Logs()
                    {
                        Id = item.Id,
                        Message = message,
                        MessageTemplate = messageTemp,
                        Level = item.Level,
                        TimeStamp = item.TimeStamp,
                        Exception = item.Exception,
                        Properties = item.Properties
                    });
                }
                else
                {
                    logList.Add(item);
                }

            }
            return View(logList);
        }

        public async Task<IActionResult> GetById(int id)
        {
            var get = await _context.Logs.FirstOrDefaultAsync(x => x.Id == id);
            return View(get);
        }
    }
}
