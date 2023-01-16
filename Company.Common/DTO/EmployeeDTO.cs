using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTO
{
    public class EmployeeDTO
    {
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public int Salary { get; set; }
        public bool LabourUnionMember { get; set; }
        public int DepartmentId { get; set; }
    }
}
