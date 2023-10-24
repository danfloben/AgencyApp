using AgencyApp.Business.Services.interfaces;
using AgencyApp.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgencyApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgencyController : ControllerBase
    {
        private IAgencyServices _agencyServices { get; }
        public AgencyController(IAgencyServices agencyServices)
        {
            _agencyServices = agencyServices;
        }
        // GET: api/<AgencyController>
        [HttpGet]
        public IEnumerable<Agency> Get()
        {
            return _agencyServices.GetAll();
        }

        // GET api/<AgencyController>/5
        [HttpGet("{id}")]
        public ActionResult<Agency> Get(int id)
        {
            var agencyByID = _agencyServices.GetById(id);
            if (agencyByID == null)
            {
                return NotFound();
            }
            return agencyByID;
        }

        // POST api/<AgencyController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Agency agency)
        {
            await _agencyServices.Create(agency);
            return CreatedAtAction(nameof(Post), new { id = agency.Id }, agency);
        }

        // PUT api/<AgencyController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Agency agency)
        {
            if (id != agency.Id)
            {
                return BadRequest();
            }

            await _agencyServices.Update(agency);

            return NoContent();
        }

        // DELETE api/<AgencyController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            var product = _agencyServices.GetById(id);
            if (product == null)
            {
                return NotFound();
            }

            await _agencyServices.Delete(product);

            return NoContent();
        }
    }
}
