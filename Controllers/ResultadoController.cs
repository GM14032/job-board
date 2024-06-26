﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using job_board.Models;

namespace job_board.Controllers
{
    [Route("api/resultado")]
    [ApiController]
    public class ResultadoController : ControllerBase
    {
        private readonly SupertexDbContext _context;

        public ResultadoController(SupertexDbContext context)
        {
            _context = context;
        }

        // GET: api/Resultado
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Resultado>>> GetResultados()
        {
            return await _context.Resultados.ToListAsync();
        }

        // GET: api/Resultado/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Resultado>> GetResultado(int id)
        {
            var resultado = await _context.Resultados.FindAsync(id);

            if (resultado == null)
            {
                return NotFound();
            }

            return resultado;
        }

        // PUT: api/Resultado/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResultado(int id, Resultado resultado)
        {
            if (id != resultado.Id)
            {
                return BadRequest();
            }

            _context.Entry(resultado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResultadoExists(id))
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

        // POST: api/Resultado
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Resultado>> PostResultado(Resultado resultado)
        {
            _context.Resultados.Add(resultado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetResultado", new { id = resultado.Id }, resultado);
        }

        // DELETE: api/Resultado/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResultado(int id)
        {
            var resultado = await _context.Resultados.FindAsync(id);
            if (resultado == null)
            {
                return NotFound();
            }

            _context.Resultados.Remove(resultado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ResultadoExists(int id)
        {
            return _context.Resultados.Any(e => e.Id == id);
        }
    }
}
