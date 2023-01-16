

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {

        private readonly IDbService _db;

        public DepartmentController(IDbService db)
        {
            _db= db;
        }


        // GET: api/<DepartmentController>
        [HttpGet]
        public async Task<IResult> Get()
            => await _db.HttpGet<Department, DepartmentDTO>();


        // GET api/<DepartmentController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id)
            => await _db.HttpGet<Department, DepartmentDTO>(id);

        // POST api/<DepartmentController>
        [HttpPost]

        public async Task<IResult> Post([FromBody] DepartmentDTO dto)
            => await _db.HttpPost<Department, DepartmentDTO>(dto);

        // PUT api/<DepartmentController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] DepartmentDTO dto)
            => await _db.HttpPut<Department, DepartmentDTO>(id, dto);

        // DELETE api/<DepartmentController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
         => await _db.HttpDelete<Department>(id);
    }
}
