using AracTescil.Models;
using AracTescil.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AracTescil.Controllers
{
    public class MarkalarController :Controller
    {
        private readonly AracTescilDbContext context;
        public MarkalarController(AracTescilDbContext context)
        {
            this.context = context;
        }
        [HttpGet("/api/markalar")]
        public async Task<IEnumerable<Marka>> GetMarkalar()
        {
            return await context.Markalar.Include(m => m.Modeller).ToListAsync();
        }
    }
}
