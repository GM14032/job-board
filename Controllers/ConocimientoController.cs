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
    [Route("api/conocimiento")]
    [ApiController]
    public class ConocimientoController : ControllerBase
    {
        private readonly SupertexDbContext _context;

        public ConocimientoController(SupertexDbContext context)
        {
            _context = context;
        }

        // GET: api/Conocimiento
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Conocimiento>>> GetConocimientos()
        {
            return await _context.Conocimientos.ToListAsync();
        }

        // GET: api/Conocimiento/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Conocimiento>> GetConocimiento(int id)
        {
            var conocimiento = await _context.Conocimientos.FindAsync(id);

            if (conocimiento == null)
            {
                return NotFound();
            }

            return conocimiento;
        }

        // PUT: api/Conocimiento/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConocimiento(int id, Conocimiento conocimiento)
        {
            if (id != conocimiento.Id)
            {
                return BadRequest();
            }

            _context.Entry(conocimiento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConocimientoExists(id))
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

        // POST: api/Conocimiento
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Conocimiento>> PostConocimiento(Conocimiento conocimiento)
        {
            _context.Conocimientos.Add(conocimiento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConocimiento", new { id = conocimiento.Id }, conocimiento);
        }

        // DELETE: api/Conocimiento/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConocimiento(int id)
        {
            var conocimiento = await _context.Conocimientos.FindAsync(id);
            if (conocimiento == null)
            {
                return NotFound();
            }

            _context.Conocimientos.Remove(conocimiento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConocimientoExists(int id)
        {
            return _context.Conocimientos.Any(e => e.Id == id);
        }
    }
}
