using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using job_board.Models;

namespace job_board.Controllers
{
    [Route("api/aspirante")]
    [ApiController]
    public class AspirantesController : ControllerBase
    {
        private readonly SupertexDbContext _context;

        public AspirantesController(SupertexDbContext context)
        {
            _context = context;
        }

        // GET: api/Aspirantes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aspirante>>> GetAspirantes()
        {
          if (_context.Aspirantes == null)
          {
              return NotFound();
          }
            return await _context.Aspirantes.ToListAsync();
        }

        // GET: api/Aspirantes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Aspirante>> GetAspirante(int id)
        {
          if (_context.Aspirantes == null)
          {
              return NotFound();
          }
            var aspirante = await _context.Aspirantes.FindAsync(id);

            if (aspirante == null)
            {
                return NotFound();
            }

            return aspirante;
        }

        // PUT: api/Aspirantes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAspirante(int id, Aspirante aspirante)
        {
            if (id != aspirante.Id)
            {
                return BadRequest();
            }

            _context.Entry(aspirante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AspiranteExists(id))
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

        // POST: api/Aspirantes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Aspirante>> PostAspirante(Aspirante aspirante)
        {
          if (_context.Aspirantes == null)
          {
              return Problem("Entity set 'SupertexDbContext.Aspirantes'  is null.");
          }
            _context.Aspirantes.Add(aspirante);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AspiranteExists(aspirante.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAspirante", new { id = aspirante.Id }, aspirante);
        }

        // DELETE: api/Aspirantes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAspirante(int id)
        {
            if (_context.Aspirantes == null)
            {
                return NotFound();
            }
            var aspirante = await _context.Aspirantes.FindAsync(id);
            if (aspirante == null)
            {
                return NotFound();
            }

            _context.Aspirantes.Remove(aspirante);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AspiranteExists(int id)
        {
            return (_context.Aspirantes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
