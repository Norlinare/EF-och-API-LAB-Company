
using Company.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Company.Data.Entities
{
    public class Organisation :IEntity
    {
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string OrganisationName { get; set; }
        [MaxLength(50), Required]
        public int OrganisationNumber { get; set;}

        public virtual ICollection<Department>? Departments { get; set; }

    }
}
