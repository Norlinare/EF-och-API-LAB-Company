using Company.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities
{
    public class Role : IEntity
    {
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string Description { get; set; }

        public ICollection<Employee>? Employees { get; set; }
    }
}
