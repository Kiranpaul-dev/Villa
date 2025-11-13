using Microsoft.AspNetCore.Mvc;
using Villa.Data;
using Villa.Logging;
using Villa.Models;
using Villa.Models.DTO;

namespace Villa.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class villa : ControllerBase
    {
        //public readonly ILogger<villa> _logger;
        public readonly ILogging _logger;
        public readonly ApplicationDbContext _context;
        public villa(ILogging logger,ApplicationDbContext context) 
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VillaDTO>> GetModels()
        {
            _logger.Log("Getting all the modesls---------------------","error");
            return Ok(_context.villas.ToList());

        }

        [HttpGet("id")]
        public ActionResult<VillaDTO> GetModel(int id)
        {
            _logger.Log("Getting all modesls----", "");
            return Ok(_context.villas.FirstOrDefault(u => u.Id==id));
        }

        [HttpPost("addVilla")]
        public ActionResult<VillaDTO> addvilla(VillaDTO villaDTO)
        {
          
            VillaModel model = new()
            {
                Name = villaDTO.Name,
                Details = villaDTO.Details,
                Rate = villaDTO.Rate,
                occupcys=villaDTO.occupcys,
                Amenity = villaDTO.Amenity,
                ImageUrl=villaDTO.ImageUrl
            };
            _context.Add(model);
            _context.SaveChanges();
            return Ok(model);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpDelete("removevilla/id")]
        public IActionResult DeleteModel(int id)
        {
            var villa=_context.villas.FirstOrDefault(v => v.Id==id);
            if (villa != null) 
            { 
                _context.villas.Remove(villa);
                _context.SaveChanges();
                return Ok(_context.villas.ToList());
            } 
            
            return NotFound();
        }

        [HttpPut("UpdateVilla")]
        public IActionResult updatevilla(int id,[FromBody]VillaDTO villa)
        {
            var vill = _context.villas.FirstOrDefault(u => u.Id == id);
            if (vill != null)
            {
                vill.Name = villa.Name;
                vill.occupcys = villa.occupcys;
                vill.sqft = villa.sqft;
                _context.SaveChanges();
                return NoContent();
            }
            return NotFound();
        }

    }
}
 