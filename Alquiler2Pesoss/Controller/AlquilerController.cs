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


        //[HttpPut("{Id}")]
        //public async Task<ActionResult<List<Producto>>> VentaActualizada(Producto request)
        //{
        //    var dbalquiler = await Context.TablaPrpducto.FindAsync(request.Id);

        //    if (dbalquiler == null)
        //        return BadRequest("venta no encontrada");


        //    dbalquiler.NombreProducto = request.NombreProducto;
        //    dbalquiler.PrecioProducto = request.PrecioProducto;
        //    dbalquiler.DetallesProducto = request.DetallesProducto;
        //    dbalquiler.FotoProducto = request.FotoProducto;

        //    await Context.SaveChangesAsync();

        //    return Ok(await Context.TablaPrpducto.ToListAsync());
        //}



    }
}
