using AppMaquinaBD.Data;
using AppMaquinaBD.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppMaquina.Server.Controllers
{
    [ApiController]
    [Route("api/Trabajos")]
    public class TrabajoController : ControllerBase
    {
        private readonly Context context;

        public TrabajoController(Context context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Trabajo>>> Get() 
        {
            return await context.Trabajos.ToListAsync(); 
        }
    }
}
