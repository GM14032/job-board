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

    public class EmpresaDto
    {
        public int? Id { get; set; }
        public string? Nombre { get; set; }

        public string? Descripcion { get; set; }

        public string? Ubicacion { get; set; }

        public string? Telefono { get; set; }

        public string? Email { get; set; }
    }

    [Route("api/empresa")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly SupertexDbContext _context;

        public EmpresaController(SupertexDbContext context)
        {
            _context = context;
        }

        // GET: api/Empresa
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empresa>>> GetEmpresas()
        {
            return await _context.Empresas.ToListAsync();
        }

        // GET: api/Empresa/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Empresa>> GetEmpresa(int id)
        {
            var empresa = await _context.Empresas.FindAsync(id);

            if (empresa == null)
            {
                return NotFound();
            }

            return empresa;
        }

        // PUT: api/Empresa/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpresa(int id, EmpresaDto empresaDto)
        {
            if (id != empresaDto.Id)
            {
                return BadRequest();
            }
            Empresa empresa = new Empresa();
            empresa.Id = id;
            empresa.Nombre = empresaDto.Nombre;
            empresa.Email = empresaDto.Email;
            empresa.Descripcion = empresaDto.Descripcion;
            empresa.Telefono = empresaDto.Telefono;
            empresa.Ubicacion = empresaDto.Ubicacion;
            _context.Entry(empresa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpresaExists(id))
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

        // POST: api/Empresa
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Empresa>> PostEmpresa(EmpresaDto empresaDto)
        {
            Empresa empresa = new Empresa();
            empresa.Nombre = empresaDto.Nombre;
            empresa.Email = empresaDto.Email;
            empresa.Descripcion = empresaDto.Descripcion;
            empresa.Telefono = empresaDto.Telefono;
            empresa.Ubicacion = empresaDto.Ubicacion;
            _context.Empresas.Add(empresa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpresa", new { id = empresa.Id }, empresa);
        }

        // DELETE: api/Empresa/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpresa(int id)
        {
            var empresa = await _context.Empresas.FindAsync(id);
            if (empresa == null)
            {
                return NotFound();
            }

            _context.Empresas.Remove(empresa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpresaExists(int id)
        {
            return _context.Empresas.Any(e => e.Id == id);
        }
    }
}
