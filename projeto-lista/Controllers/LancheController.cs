using System.Collections.Generic;
using projeto_lista.Entities;
using projeto_lista.Services;
using Microsoft.AspNetCore.Mvc;

namespace projeto_lista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LancheController : ControllerBase
    {
        private readonly LancheService _lancheService;
        
        public LancheController(LancheService lancheService) {
            _lancheService = lancheService;
        }

        [HttpGet]
        public ActionResult<List<Lanche>> Get() {
            return _lancheService.Get();
        } 

        [HttpGet("{id:length(24)}", Name = "GetLanche")]
        public ActionResult<Lanche> Get(string id) {
            var lanche =  _lancheService.Get(id);

            if (lanche == null) {
                return NotFound();
            }

            return lanche;
        }

        [HttpPost]
        public ActionResult<Lanche> Create(Lanche lanche) {
            _lancheService.Craate(lanche);
            return CreatedAtRoute("GetLanche", new { id = lanche.Id.ToString() }, lanche);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Lanche lanche) {

            var lan = _lancheService.Get(id);

            if (lan == null) {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id) {
            
            var lan = _lancheService.Get(id);

            if (lan == null) {
                return NotFound();
            }

            _lancheService.Remove(lan.Id);
            return NoContent();
        }
    }
}