


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganisationController : ControllerBase
    {

        private readonly IDbService _db;

        public OrganisationController(IDbService db)
        {
            _db= db;
        }


        // GET: api/<OrganisationController>
        [HttpGet]
        public async Task<IResult> Get()
            => await _db.HttpGet<Organisation, OrganisationDTO>();


        // GET api/<OrganisationController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id)
            => await _db.HttpGet<Organisation, OrganisationDTO>(id);

        // POST api/<OrganisationController>
        [HttpPost]

        public async Task<IResult> Post([FromBody] OrganisationDTO dto)
            => await _db.HttpPost<Organisation, OrganisationDTO>(dto);

        // PUT api/<OrganisationController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] OrganisationDTO dto)
            => await _db.HttpPut<Organisation, OrganisationDTO>(id, dto);

        // DELETE api/<OrganisationController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
         => await _db.HttpDelete<Organisation>(id);
    }
}
