using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using job_board.Models;

namespace job_board.Controllers
{
    [Route("api/experiencia")]
    [ApiController]
    public class ExperienciaController : ControllerBase
    {
        private readonly SupertexDbContext _context;

        public ExperienciaController(SupertexDbContext context)
        {
            _context = context;
        }

        // GET: api/Experiencia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Experiencium>>> GetExperiencia()
        {
            return await _context.Experiencia.ToListAsync();
        }

        // GET: api/Experiencia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Experiencium>> GetExperiencium(int id)
        {
            var experiencium = await _context.Experiencia.FindAsync(id);

            if (experiencium == null)
            {
                return NotFound();
            }

            return experiencium;
        }

        // PUT: api/Experiencia/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExperiencium(int id, Experiencium experiencium)
        {
            if (id != experiencium.Id)
            {
                return BadRequest();
            }

            _context.Entry(experiencium).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExperienciumExists(id))
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

        // POST: api/Experiencia
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Experiencium>> PostExperiencium(Experiencium experiencium)
        {
            _context.Experiencia.Add(experiencium);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExperiencium", new { id = experiencium.Id }, experiencium);
        }

        // DELETE: api/Experiencia/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExperiencium(int id)
        {
            var experiencium = await _context.Experiencia.FindAsync(id);
            if (experiencium == null)
            {
                return NotFound();
            }

            _context.Experiencia.Remove(experiencium);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExperienciumExists(int id)
        {
            return _context.Experiencia.Any(e => e.Id == id);
        }
    }
}
