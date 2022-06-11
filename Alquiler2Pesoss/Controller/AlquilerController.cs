using Alquiler2Pesoss.Data;
using Alquiler2Pesoss.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Alquiler2Pesoss.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlquilerController : ControllerBase
    {

        private readonly dbcontext Context;

        public AlquilerController(dbcontext context)
        {
            Context = context;
        }


        [HttpPost]
        public async Task<ActionResult<List<Producto>>> addVenta(Producto productos)
        {
            Context.TablaPrpducto.Add(productos);
            await Context.SaveChangesAsync();
            return Ok(await Context.TablaPrpducto.ToListAsync());



        }



    }
}
