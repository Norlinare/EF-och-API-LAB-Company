
using Company.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Company.Data.Entities
{
    public class Department : IEntity
    {
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string DepartmentName { get; set; }

        public int OrganisationId { get; set; }

        public virtual Organisation? Organisation { get; set; }
    }
}
