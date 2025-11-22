using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.DataContext;
using Service.Models;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly MusicCoreContext _context;

        public VentasController(MusicCoreContext context)
        {
            _context = context;
        }

        // GET: api/Ventas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Venta>>> GetVentas()
        {
            return await _context.Ventas
                        .Include(v => v.Cliente)
                        .Include(v => v.Usuario)
                        .Include(v => v.Disco)
                        .ToListAsync();
        }

        // GET: api/Ventas/deleteds
        [HttpGet("deleteds/")]
        public async Task<ActionResult<IEnumerable<Venta>>> GetVentasDeleteds()
        {
            return await _context.Ventas.IgnoreQueryFilters().Where(c => c.IsDeleted.Equals(true)).ToListAsync();
        }

        // GET: api/Ventas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Venta>> GetVenta(int id)
        {
            var venta = await _context.Ventas.FindAsync(id);

            if (venta == null)
            {
                return NotFound();
            }

            return venta;
        }

        // PUT: api/Ventas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVenta(int id, Venta venta)
        {
            if (id != venta.Id)
            {
                return BadRequest();
            }

            _context.Entry(venta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VentaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Ventas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Venta>> PostVenta(Venta venta)
        {
            _context.Ventas.Add(venta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVenta", new { id = venta.Id }, venta);
        }

        // DELETE: api/Ventas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVenta(int id)
        {
            var venta = await _context.Ventas.FindAsync(id);
            if (venta == null)
            {
                return NotFound();
            }

            //borrado lógico
            venta.IsDeleted = true;
            _context.Ventas.Update(venta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // PUT: api/Ventas/restore/5
        [HttpPut("restore/{id}")]
        public async Task<IActionResult> RestoreArtista(int id)
        {
            var venta = await _context.Ventas
                .IgnoreQueryFilters()
                .Include(c => c.Cliente)
                .Include(c => c.Usuario)
                .Include(c => c.Disco)
                .FirstOrDefaultAsync(c => c.Id.Equals(id));

            if (venta == null)
            {
                return NotFound();
            }

            venta.IsDeleted = false; //soft restore
            _context.Ventas.Update(venta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VentaExists(int id)
        {
            return _context.Ventas.Any(e => e.Id == id);
        }
    }
}
