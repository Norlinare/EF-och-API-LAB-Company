


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IDbService _db;

        public EmployeeController(IDbService db)
        {
            _db= db;
        }


        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IResult> Get()
            => await _db.HttpGet<Employee, EmployeeDTO>();


        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id)
            => await _db.HttpGet<Employee, EmployeeDTO>(id);

        // POST api/<EmployeeController>
        [HttpPost]

        public async Task<IResult> Post([FromBody] EmployeeDTO dto)
            => await _db.HttpPost<Employee, EmployeeDTO>(dto);

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] EmployeeDTO dto)
            => await _db.HttpPut<Employee, EmployeeDTO>(id, dto);

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
         => await _db.HttpDelete<Employee>(id);
    }
}
