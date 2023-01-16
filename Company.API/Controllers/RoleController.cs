


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {

        private readonly IDbService _db;

        public RoleController(IDbService db)
        {
            _db= db;
        }


        // GET: api/<RoleController>
        [HttpGet]
        public async Task<IResult> Get()
            => await _db.HttpGet<Role, RoleDTO>();


        // GET api/<RoleController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id)
            => await _db.HttpGet<Role, RoleDTO>(id);

        // POST api/<RoleController>
        [HttpPost]

        public async Task<IResult> Post([FromBody] RoleDTO dto)
            => await _db.HttpPost<Role, RoleDTO>(dto);

        // PUT api/<RoleController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] RoleDTO dto)
            => await _db.HttpPut<Role, RoleDTO>(id, dto);

        // DELETE api/<RoleController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
         => await _db.HttpDelete<Role>(id);
    }
}
