using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTO
{
    public class EmployeeRoleDTO
    {
        public EmployeeRoleDTO(int employeeId, int roleId) => (EmployeeId,RoleId) = (employeeId, roleId);
        
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
    }
}
