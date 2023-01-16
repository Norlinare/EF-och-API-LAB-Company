using Company.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities
{
    public class EmployeeRole : IReferenceEntity
    {
        public int EmployeeId { get; set; }
        public int RoleId { get; set;}
        
    }
}
