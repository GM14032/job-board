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
    [Route("api/habilidades")]
    [ApiController]
    public class HabilidadesController : ControllerBase
    {
        private readonly SupertexDbContext _context;

        public HabilidadesController(SupertexDbContext context)
        {
            _context = context;
        }

        // GET: api/Habilidades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Habilidade>>> GetHabilidades()
        {
            return await _context.Habilidades.ToListAsync();
        }

        // GET: api/Habilidades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Habilidade>> GetHabilidade(int id)
        {
            var habilidade = await _context.Habilidades.FindAsync(id);

            if (habilidade == null)
            {
                return NotFound();
            }

            return habilidade;
        }

        // PUT: api/Habilidades/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHabilidade(int id, Habilidade habilidade)
        {
            if (id != habilidade.Id)
            {
                return BadRequest();
            }

            _context.Entry(habilidade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HabilidadeExists(id))
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

        // POST: api/Habilidades
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Habilidade>> PostHabilidade(Habilidade habilidade)
        {
            _context.Habilidades.Add(habilidade);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHabilidade", new { id = habilidade.Id }, habilidade);
        }

        // DELETE: api/Habilidades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHabilidade(int id)
        {
            var habilidade = await _context.Habilidades.FindAsync(id);
            if (habilidade == null)
            {
                return NotFound();
            }

            _context.Habilidades.Remove(habilidade);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HabilidadeExists(int id)
        {
            return _context.Habilidades.Any(e => e.Id == id);
        }
    }
}
