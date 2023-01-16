


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using Company.API.Extensions;

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeRoleController : ControllerBase
    {

        private readonly IDbService _db;

        public EmployeeRoleController(IDbService db)
        {
            _db= db;
        }

        // POST api/<EmployeeRoleController>
        [HttpPost]

        public async Task<IResult> Post([FromBody] EmployeeRoleDTO dto)
            => await _db.HttpPostToRefEntity<EmployeeRole, EmployeeRoleDTO>(dto);


        // DELETE api/<EmployeeRoleController>/5
        [HttpDelete]
        public async Task<IResult> Delete(EmployeeRoleDTO dto)
         => await _db.HttpDeleteFromRefEntity<EmployeeRole,EmployeeRoleDTO>(dto);
    }
}
