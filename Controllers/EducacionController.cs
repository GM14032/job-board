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
    [Route("api/educacion")]
    [ApiController]
    public class EducacionController : ControllerBase
    {
        private readonly SupertexDbContext _context;

        public EducacionController(SupertexDbContext context)
        {
            _context = context;
        }

        // GET: api/Educacion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Educacion>>> GetEducacions()
        {
            return await _context.Educacions.ToListAsync();
        }

        // GET: api/Educacion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Educacion>> GetEducacion(int id)
        {
            var educacion = await _context.Educacions.FindAsync(id);

            if (educacion == null)
            {
                return NotFound();
            }

            return educacion;
        }

        // PUT: api/Educacion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEducacion(int id, Educacion educacion)
        {
            if (id != educacion.Id)
            {
                return BadRequest();
            }

            _context.Entry(educacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EducacionExists(id))
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

        // POST: api/Educacion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Educacion>> PostEducacion(Educacion educacion)
        {
            _context.Educacions.Add(educacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEducacion", new { id = educacion.Id }, educacion);
        }

        // DELETE: api/Educacion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEducacion(int id)
        {
            var educacion = await _context.Educacions.FindAsync(id);
            if (educacion == null)
            {
                return NotFound();
            }

            _context.Educacions.Remove(educacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EducacionExists(int id)
        {
            return _context.Educacions.Any(e => e.Id == id);
        }
    }
}
