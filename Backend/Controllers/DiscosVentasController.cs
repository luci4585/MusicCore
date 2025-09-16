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
    public class DiscosVentasController : ControllerBase
    {
        private readonly MusicCoreContext _context;

        public DiscosVentasController(MusicCoreContext context)
        {
            _context = context;
        }

        // GET: api/DiscosVentas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DiscoVenta>>> GetDiscoVenta()
        {
            return await _context.DiscoVenta.ToListAsync();
        }

        // GET: api/DiscosVentas/deleteds
        [HttpGet("deleteds/")]
        public async Task<ActionResult<IEnumerable<DiscoVenta>>> GetCancionesDeleteds()
        {
            return await _context.DiscosVentas.IgnoreQueryFilters().Where(c => c.IsDeleted.Equals(true)).ToListAsync();
        }

        // GET: api/DiscosVentas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DiscoVenta>> GetDiscoVenta(int id)
        {
            var discoVenta = await _context.DiscoVenta.FindAsync(id);

            if (discoVenta == null)
            {
                return NotFound();
            }

            return discoVenta;
        }

        // PUT: api/DiscosVentas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDiscoVenta(int id, DiscoVenta discoVenta)
        {
            if (id != discoVenta.VentaId)
            {
                return BadRequest();
            }

            _context.Entry(discoVenta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DiscoVentaExists(id))
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

        // POST: api/DiscosVentas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DiscoVenta>> PostDiscoVenta(DiscoVenta discoVenta)
        {
            _context.DiscoVenta.Add(discoVenta);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DiscoVentaExists(discoVenta.VentaId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDiscoVenta", new { id = discoVenta.VentaId }, discoVenta);
        }

        // DELETE: api/DiscosVentas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiscoVenta(int id)
        {
            var discoVenta = await _context.DiscoVenta.FindAsync(id);
            if (discoVenta == null)
            {
                return NotFound();
            }

            _context.DiscoVenta.Remove(discoVenta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //PUT: api/DiscosVentas/restore/5
        [HttpPut("restore/{id}")]
        public async Task<IActionResult> RestoreDiscoVenta(int id)
        {
            var discoventa = await _context.DiscosVentas.IgnoreQueryFilters().FirstOrDefaultAsync(c => c.Id.Equals(id));
            if (discoventa == null)
            {
                return NotFound();
            }

            discoventa.IsDeleted = false; //soft restore
            _context.DiscosVentas.Update(discoventa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DiscoVentaExists(int id)
        {
            return _context.DiscoVenta.Any(e => e.VentaId == id);
        }
    }
}
