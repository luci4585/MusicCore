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
    public class ArtistasController : ControllerBase
    {
        private readonly MusicCoreContext _context;

        public ArtistasController(MusicCoreContext context)
        {
            _context = context;
        }

        // GET: api/Artistas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artista>>> GetArtistas()
        {
            return await _context.Artistas.ToListAsync();
        }

        // GET: api/Artistas/deleteds
        [HttpGet("deleteds/")]
        public async Task<ActionResult<IEnumerable<Artista>>> GetArtistasDeleteds()
        {
            return await _context.Artistas.IgnoreQueryFilters().Where(c => c.IsDeleted.Equals(true)).ToListAsync();
        }

        // GET: api/Artistas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Artista>> GetArtista(int id)
        {
            var artista = await _context.Artistas.FindAsync(id);

            if (artista == null)
            {
                return NotFound();
            }

            return artista;
        }

        // PUT: api/Artistas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArtista(int id, Artista artista)
        {
            if (id != artista.ArtistaId)
            {
                return BadRequest();
            }

            _context.Entry(artista).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtistaExists(id))
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

        // POST: api/Artistas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Artista>> PostArtista(Artista artista)
        {
            _context.Artistas.Add(artista);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArtista", new { id = artista.ArtistaId }, artista);
        }

        // DELETE: api/Artistas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtista(int id)
        {
            var artista = await _context.Artistas.FindAsync(id);
            if (artista == null)
            {
                return NotFound();
            }

            //borrado logico
            artista.IsDeleted = true;
            _context.Artistas.Update(artista);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        // PUT: api/Artistas/restore/5
        [HttpPut("restore/{id}")]
        public async Task<IActionResult> RestoreArtista(int id)
        {
            var artista = await _context.Artistas.IgnoreQueryFilters().FirstOrDefaultAsync(c => c.ArtistaId.Equals(id));
            if (artista == null)
            {
                return NotFound();
            }

            artista.IsDeleted = false; //soft restore
            _context.Artistas.Update(artista);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArtistaExists(int id)
        {
            return _context.Artistas.Any(e => e.ArtistaId == id);
        }
    }
}
