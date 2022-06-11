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
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Producto>>> BorrarVenta(int id)
        {
            var dbventa = await Context.TablaPrpducto.FindAsync(id);
            if (dbventa == null)
                return BadRequest("Venta no encontrada");

            Context.TablaPrpducto.Remove(dbventa);
            await Context.SaveChangesAsync();

            return Ok(await Context.TablaPrpducto.ToListAsync());
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<List<Producto>>> VentaActualizada(Producto request)
        {
            var dbalquiler = await Context.TablaPrpducto.FindAsync(request.Id);

            if (dbalquiler == null)
                return BadRequest("venta no encontrada");


            dbalquiler.NombreProducto = request.NombreProducto;
            dbalquiler.PrecioProducto = request.PrecioProducto;
            dbalquiler.DetallesProducto = request.DetallesProducto;
            dbalquiler.FotoProducto = request.FotoProducto;

            await Context.SaveChangesAsync();

            return Ok(await Context.TablaPrpducto.ToListAsync());
        }


        [HttpGet("{id}")]

        public async Task<ActionResult<Producto>> Get(int id)
        {
            var prod = await Context.TablaPrpducto.FindAsync(id);
            if (prod == null)
            {
                return BadRequest("Venta no encontrada");
            }

            return Ok(prod);
        }



    }
}
