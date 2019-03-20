using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_lista.Entities;

namespace projeto_lista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NomeController : ControllerBase
    {
        private readonly NomeContext _context;

        public NomeController(NomeContext context) {
            _context = context;

            if (_context.NomeItems.Count() == 0) {
                // Create a new NomItem if collection is empty,
                // Cria um novo NomItem se a coleção estiver vazia,
                // which means you can't delete all NomItems.
                 // o que significa que você não pode excluir todos os NomItems.
                _context.NomeItems.Add(new NomeItem { nome = "Item1" });
                _context.SaveChanges();
            }
        }

           // GET: api/nome
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NomeItem>>> GetNomeItem(){
            return await _context.NomeItems.ToListAsync();
        }

        // GET: api/nome/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NomeItem>> GetNomeItem(long id) {
            var nomeItem = await _context.NomeItems.FindAsync(id);

            if (nomeItem == null) {
                return NotFound();
            }

            return nomeItem;
        }

        // POST: api/nome
        [HttpPost]
        public async Task<ActionResult<NomeItem>> PostNomeItem(NomeItem item) {
            _context.NomeItems.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetNomeItem), new { id = item.Id}, item);
        }

         // PUT: api/nome
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNomeItem(long id, NomeItem item) {

            if (id != item.Id) {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/nome
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNomeItem(long id) {
            var nomeItem = await _context.NomeItems.FindAsync(id);

            if (nomeItem == null) {
                return NotFound();
            }

            _context.NomeItems.Remove(nomeItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}