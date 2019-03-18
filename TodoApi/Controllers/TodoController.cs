using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Entities;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TestContext _context;

        public TodoController(TestContext context) {
            _context = context;

            if (_context.TestApi.Count() == 0) {
                // Create a new TodoItem if collection is empty,
                // Cria um novo TodoItem se a coleção estiver vazia,
                // which means you can't delete all TodoItems.
                // o que significa que você não pode excluir todos os TodoItems.
                _context.TestApi.Add(new TestApi { name = "Item1"});
                _context.SaveChanges();
            }
        }

        // GET: api/todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestApi>>> GetTestApi(){
            return await _context.TestApi.ToListAsync();
        }

        // GET: api/todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TestApi>> GetTestApi(long id) {
            var testApi = await _context.TestApi.FindAsync(id);

            if (testApi == null) {
                return NotFound();
            }

            return testApi;
        }

        // POST: api/todo
        [HttpPost]
        public async Task<ActionResult<TestApi>> PostTestApi(TestApi item) {
            _context.TestApi.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTestApi), new { id = item.Id}, item);
        }

        // PUT: api/todo
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestApi(long id, TestApi item) {
            return NoContent();
        }
    }
}