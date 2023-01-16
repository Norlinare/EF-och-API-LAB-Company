
using Company.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Company.Data.Entities
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string GivenName { get; set; }
        [MaxLength(50), Required]
        public string FamilyName { get; set; }
        [MaxLength(50), Required]
        public int Salary { get; set; }
        [Required]
        public bool LabourUnionMember { get; set; }

        public int DepartmentId { get; set; }

        public Department? Department { get; set; }
        public virtual ICollection<Role>? Roles { get; set; }
    }
}
