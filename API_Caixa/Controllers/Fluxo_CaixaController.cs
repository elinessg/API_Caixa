using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Caixa.Data;
using API_Caixa.Models;

namespace API_Caixa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Fluxo_CaixaController : ControllerBase
    {
        private readonly API_CaixaContext _context;

        public Fluxo_CaixaController(API_CaixaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Obter todos os registros
        /// </summary>
        /// <response code="200">A lista de usuários foi obtida com sucesso.</response>
        /// <response code="500">Ocorreu um erro ao obter a lista de usuários.</response>
        // GET: api/TB_Fluxo_Caixa
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TB_Fluxo_Caixa>>> GetTB_Fluxo_Caixa()
        {
            return await _context.TB_Fluxo_Caixa.ToListAsync();
        }

        // GET: api/TB_Fluxo_Caixa/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TB_Fluxo_Caixa>> GetTB_Fluxo_Caixa(int id)
        {
            var tB_Fluxo_Caixa = await _context.TB_Fluxo_Caixa.FindAsync(id);

            if (tB_Fluxo_Caixa == null)
            {
                return NotFound();
            }

            return tB_Fluxo_Caixa;
        }

        

        // POST: api/TB_Fluxo_Caixa
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TB_Fluxo_Caixa>> PostTB_Fluxo_Caixa(TB_Fluxo_Caixa tB_Fluxo_Caixa)
        {
            _context.TB_Fluxo_Caixa.Add(tB_Fluxo_Caixa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTB_Fluxo_Caixa", new { id = tB_Fluxo_Caixa.Id }, tB_Fluxo_Caixa);
        }

        

        private bool TB_Fluxo_CaixaExists(int id)
        {
            return _context.TB_Fluxo_Caixa.Any(e => e.Id == id);
        }
    }
}
