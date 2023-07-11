using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WhatsWrongAPI.Data;
using WhatsWrongAPI.Models;

namespace WhatsWrongAPI.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public VillaAPIController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Villa>>> GetVillas()
        {
                throw new NullReferenceException();
                return Ok(await _db.Villas.ToListAsync());
        }

        [HttpGet("{id:int}", Name = "GetVilla")]
        public async Task<ActionResult<Villa>> GetVilla(int id)
        {
            
                var villa = await _db.Villas.FirstOrDefaultAsync(u => u.Id == id);
                if (villa == null)
                {
                    return NotFound();
                }

                return Ok(villa);
           
        }

        [HttpPost]
        public async Task<ActionResult<Villa>> CreateVilla([FromBody] Villa villaDTO)
        {
           
                if (villaDTO == null)
                {
                    return BadRequest(villaDTO);
                }
                await _db.Villas.AddAsync(villaDTO);
                await _db.SaveChangesAsync();
                return CreatedAtRoute("GetVilla", new { id = villaDTO.Id }, villaDTO);
           
        }


        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        public async Task<IActionResult> DeleteVilla(int id)
        {
            
                var villa = await _db.Villas.FirstOrDefaultAsync(u => u.Id == id);
                if (villa == null) return NotFound();
                _db.Villas.Remove(villa);
                await _db.SaveChangesAsync();
                return NoContent();
            
        }

        [HttpPut("{id:int}", Name = "UpdateVilla")]
        public async Task<IActionResult> UpdateVilla(int id, [FromBody] Villa villaDTO)
        {
            
                if (villaDTO == null || id != villaDTO.Id)
                {
                    return BadRequest();
                }
                _db.Villas.Update(villaDTO);
                await _db.SaveChangesAsync();
                return NoContent();
           
        }

    }

}
