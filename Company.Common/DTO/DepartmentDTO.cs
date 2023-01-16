using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTO
{
    public class DepartmentDTO
    {
        public string DepartmentName { get; set; }
        public int OrganisationId { get; set; }
    }
}
