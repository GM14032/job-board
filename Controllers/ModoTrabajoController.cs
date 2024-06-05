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
    [Route("api/modoTrabajo")]
    [ApiController]
    public class ModoTrabajoController : ControllerBase
    {
        private readonly SupertexDbContext _context;

        public ModoTrabajoController(SupertexDbContext context)
        {
            _context = context;
        }

        // GET: api/ModoTrabajo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModoTrabajo>>> GetModoTrabajos()
        {
            return await _context.ModoTrabajos.ToListAsync();
        }

        // GET: api/ModoTrabajo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ModoTrabajo>> GetModoTrabajo(int id)
        {
            var modoTrabajo = await _context.ModoTrabajos.FindAsync(id);

            if (modoTrabajo == null)
            {
                return NotFound();
            }

            return modoTrabajo;
        }

        // PUT: api/ModoTrabajo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModoTrabajo(int id, ModoTrabajo modoTrabajo)
        {
            if (id != modoTrabajo.Id)
            {
                return BadRequest();
            }

            _context.Entry(modoTrabajo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModoTrabajoExists(id))
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

        // POST: api/ModoTrabajo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ModoTrabajo>> PostModoTrabajo(ModoTrabajo modoTrabajo)
        {
            _context.ModoTrabajos.Add(modoTrabajo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetModoTrabajo", new { id = modoTrabajo.Id }, modoTrabajo);
        }

        // DELETE: api/ModoTrabajo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModoTrabajo(int id)
        {
            var modoTrabajo = await _context.ModoTrabajos.FindAsync(id);
            if (modoTrabajo == null)
            {
                return NotFound();
            }

            _context.ModoTrabajos.Remove(modoTrabajo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ModoTrabajoExists(int id)
        {
            return _context.ModoTrabajos.Any(e => e.Id == id);
        }
    }
}
