using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Veterinary.API.Data;
using Veterinary.Shared.Entities;

namespace Veterinary.API.Controllers
{
    [ApiController]
    [Route("/api/owners")] //Ruta personalizada
    public class OwnersController : ControllerBase
    {
        private readonly DataContext _context;

        //Constructor
        public OwnersController(DataContext context)
        {
            _context = context;
        }

        //Metodo Get - Lista (Read all)
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Owners.ToListAsync());
        }

        //Create
        [HttpPost]
        public async Task<ActionResult> Post(Owner owner)
        {
            _context.Add(owner);
            await _context.SaveChangesAsync();
            return Ok(owner);
        }

        //Get por ID (Read)
        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {
            var owner = await _context.Owners.FirstOrDefaultAsync
                (x => x.Id == id);

            if (owner == null)
            {
                return NotFound();
            }
            return Ok(owner);
        }

        //Update
        [HttpPut]
        public async Task<ActionResult> Put(Owner owner)
        {
            _context.Update(owner);
            await _context.SaveChangesAsync();
            return Ok(owner);
        }

        //Delete
        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {
            var filasafectadas = await _context.Owners.Where(x => x.Id == id).
                ExecuteDeleteAsync();

            if (filasafectadas == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
