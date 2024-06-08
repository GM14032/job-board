using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using job_board.Models;
using System.Text.Json.Serialization;
using job_board.Dto;

namespace job_board.Controllers
{

    [Route("api/ofertaLaboral")]
    [ApiController]
    public class OfertaLaboralController : ControllerBase
    {
        private readonly SupertexDbContext _context;

        public OfertaLaboralController(SupertexDbContext context)
        {
            _context = context;
        }

        // GET: api/OfertaLaboral
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OfertaLaboral>>> GetOfertaLaborals()
        {
            return await _context.OfertaLaborals.ToListAsync();
        }

        // GET: api/OfertaLaboral/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OfertaLaboral>> GetOfertaLaboral(int id)
        {
            var ofertaLaboral = await _context.OfertaLaborals.FindAsync(id);

            if (ofertaLaboral == null)
            {
                return NotFound();
            }

            return ofertaLaboral;
        }

        [HttpGet("{id}/company")]
        public async Task<ActionResult<IEnumerable<OfertaLaboral>>> GetOfertaLaboralByCompany(int id)
        {
            return await _context.OfertaLaborals.Where(o => o.IdEmpresa == id).ToListAsync();
        }

        // PUT: api/OfertaLaboral/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOfertaLaboral(int id, OfertaLaboral ofertaLaboral)
        {
            if (id != ofertaLaboral.Id)
            {
                return BadRequest();
            }

            _context.Entry(ofertaLaboral).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OfertaLaboralExists(id))
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

        // POST: api/OfertaLaboral
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OfertaLaboral>> PostOfertaLaboral(OfertaLaboralDto ofertaLaboralDto)
        {
            OfertaLaboral ofertaLaboral = new OfertaLaboral();
            ofertaLaboral.SalarioMin = ofertaLaboralDto.SalarioMin;
            ofertaLaboral.SalarioMax = ofertaLaboralDto.SalarioMax;
            ofertaLaboral.IdModoTrabajo = ofertaLaboralDto.IdModoTrabajo;
            ofertaLaboral.Nombre = ofertaLaboralDto.Nombre;
            ofertaLaboral.Descripcion = ofertaLaboralDto.Descripcion;
            ofertaLaboral.Experiencia = ofertaLaboralDto.Experiencia;
            ofertaLaboral.IdEmpresa = ofertaLaboralDto.IdEmpresa;
            ofertaLaboral.PerfilAcademico = ofertaLaboralDto.PerfilAcademico;
            _context.OfertaLaborals.Add(ofertaLaboral);
            await _context.SaveChangesAsync();
            foreach(ConocimientoDto c in ofertaLaboralDto.Conocimientos)
            {
                Conocimiento conocimiento = new Conocimiento();
                conocimiento.Descripcion = c.Descripcion;
                conocimiento.Nivel = c.Nivel;
                conocimiento.Nombre = c.Nombre;
                conocimiento.IdOferta = ofertaLaboral.Id;
                _context.Conocimientos.Add(conocimiento);
            }
            await _context.SaveChangesAsync();
            foreach(HabilidadDto h in ofertaLaboralDto.Habilidades)
            {
                Habilidade habilidad = new Habilidade();
                habilidad.Nombre = h.Nombre;
                habilidad.Descripcion = h.Descripcion;
                habilidad.IdOferta = ofertaLaboral.Id;
                _context.Habilidades.Add(habilidad);
            }
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOfertaLaboral", new { id = ofertaLaboral.Id }, ofertaLaboral);
        }

        // DELETE: api/OfertaLaboral/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOfertaLaboral(int id)
        {
            var ofertaLaboral = await _context.OfertaLaborals.FindAsync(id);
            if (ofertaLaboral == null)
            {
                return NotFound();
            }

            _context.OfertaLaborals.Remove(ofertaLaboral);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OfertaLaboralExists(int id)
        {
            return _context.OfertaLaborals.Any(e => e.Id == id);
        }
    }
}
