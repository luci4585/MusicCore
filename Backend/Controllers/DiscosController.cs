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
    public class DiscosController : ControllerBase
    {
        private readonly MusicCoreContext _context;

        public DiscosController(MusicCoreContext context)
        {
            _context = context;
        }

        // GET: api/Discos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Disco>>> GetDiscos()
        {
            return await _context.Discos
                .Include(d => d.Artista)
                .Include(d => d.Genero)
                .Include(d => d.Canciones)
                .Include(d => d.DiscoVentas)
                .ToListAsync();
        }

        // GET: api/Discos/deleteds
        [HttpGet("deleteds/")]
        public async Task<ActionResult<IEnumerable<Disco>>> GetDiscosDeleteds()
        {
            return await _context.Discos.IgnoreQueryFilters().Where(c => c.IsDeleted.Equals(true)).ToListAsync();
        }

        // GET: api/Discos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Disco>> GetDisco(int id)
        {
            var disco = await _context.Discos.FindAsync(id);

            if (disco == null)
            {
                return NotFound();
            }

            return disco;
        }

        // PUT: api/Discos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDisco(int id, Disco disco)
        {
            if (id != disco.Id)
            {
                return BadRequest();
            }

            _context.Entry(disco).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DiscoExists(id))
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

        // POST: api/Discos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Disco>> PostDisco(Disco disco)
        {
            _context.Discos.Add(disco);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDisco", new { id = disco.Id }, disco);
        }

        // DELETE: api/Discos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDisco(int id)
        {
            var disco = await _context.Discos.FindAsync(id);
            if (disco == null)
            {
                return NotFound();
            }

            _context.Discos.Remove(disco);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // PUT: api/Discos/restore/5
        [HttpPut("restore/{id}")]
        public async Task<IActionResult> RestoreDisco(int id)
        {
            var disco = await _context.Discos.IgnoreQueryFilters().FirstOrDefaultAsync(c => c.Id.Equals(id));
            if (disco == null)
            {
                return NotFound();
            }

            disco.IsDeleted = false; //soft restore
            _context.Discos.Update(disco);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DiscoExists(int id)
        {
            return _context.Discos.Any(e => e.Id == id);
        }
    }
}
