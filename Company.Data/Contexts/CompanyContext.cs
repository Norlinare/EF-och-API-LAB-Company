using Microsoft.EntityFrameworkCore;
using Company.Data.Entities;

namespace Company.Data.Contexts
{
    public class CompanyContext : DbContext
    {
        public DbSet<Organisation> Companies => Set<Organisation>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<EmployeeRole> EmployeeRoles => Set<EmployeeRole>();
        public DbSet<Role> Roles => Set<Role>();


        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EmployeeRole>().HasKey(er =>
                 new { er.EmployeeId, er.RoleId });

            base.OnModelCreating(builder);

            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            var company = new List<Organisation>
            {
                new Entities.Organisation
                {
                 Id = 1,
                 OrganisationName = "TechnicalTruth Global",
                 OrganisationNumber = 254054266,
                },
                new Entities.Organisation
                {
                 Id = 2,
                 OrganisationName = "TechnicalTruth Sweden",
                 OrganisationNumber = 254054296,
                },
                new Entities.Organisation
                {
                 Id = 3,
                 OrganisationName = "TechnicalTruth Norway",
                 OrganisationNumber = 224457224,
                },
                new Entities.Organisation
                {
                 Id = 4,
                 OrganisationName = "TechnicalTruth Finland",
                 OrganisationNumber = 124544396,
                },
                new Entities.Organisation
                {
                 Id = 5,
                 OrganisationName = "TechnicalTruth Denmark",
                 OrganisationNumber = 255023126,
                },
            };

            builder.Entity<Organisation>().HasData(company);

            var departments = new List<Department>
            {
                new Department
                {
                 Id = 1,
                 DepartmentName ="Headquarter Sweden",
                 OrganisationId= 1,
                },
                new Department
                {
                 Id = 2,
                 DepartmentName ="Development Sweden",
                 OrganisationId= 2,
                },
                new Department
                {
                 Id = 3,
                 DepartmentName ="Research Finland",
                 OrganisationId= 4,
                },
                new Department
                {
                 Id = 4,
                 DepartmentName ="HR Service Sweden",
                 OrganisationId= 2,
                },
                new Department
                {
                 Id = 5,
                 DepartmentName ="Global Contact Sweden",
                 OrganisationId= 2,
                },
                new Department
                {
                 Id = 6,
                 DepartmentName ="Advertising Denmark",
                 OrganisationId= 5,
                },
                new Department
                {
                 Id = 7,
                 DepartmentName ="IT Support Norway",
                 OrganisationId= 3,
                },
            };

            builder.Entity<Department>().HasData(departments);

            var employees = new List<Employee>
            {
                new Employee
                {
                 Id = 1,
                 GivenName = "Roland",
                 FamilyName = "Sanne",
                 Salary =452412,
                 LabourUnionMember= false,
                 DepartmentId= 1,
                },
                new Employee
                {
                 Id = 2,
                 GivenName = "Maria",
                 FamilyName = "Josefsson",
                 Salary = 44412,
                 LabourUnionMember= false,
                 DepartmentId= 1,
                },
                new Employee
                {
                 Id = 3,
                 GivenName = "Lena",
                 FamilyName = "Aldien",
                 Salary = 24412,
                 LabourUnionMember= true,
                 DepartmentId= 2,
                },
                new Employee
                {
                 Id = 4,
                 GivenName = "Bert",
                 FamilyName = "Norlen",
                 Salary = 42412,
                 LabourUnionMember= false,
                 DepartmentId= 2,
                },
                new Employee
                {
                 Id = 5,
                 GivenName = "Moa",
                 FamilyName = "Liiv",
                 Salary = 31412,
                 LabourUnionMember= true,
                 DepartmentId= 1,
                },
                new Employee
                {
                 Id = 6,
                 GivenName = "Robert",
                 FamilyName = "Pettersson",
                 Salary = 21412,
                 LabourUnionMember= true,
                 DepartmentId= 4,
                },
                new Employee
                {
                 Id = 7,
                 GivenName = "Gustav",
                 FamilyName = "Vikman",
                 Salary = 34112,
                 LabourUnionMember= false,
                 DepartmentId= 3,
                },
                new Employee
                {
                 Id = 8,
                 GivenName = "Henrik",
                 FamilyName = "Svente",
                 Salary = 23412,
                 LabourUnionMember= false,
                 DepartmentId= 6,
                },


            };

            builder.Entity<Employee>().HasData(employees);

            var employeeRoles = new List<EmployeeRole>
            {
                new EmployeeRole
                {
                 EmployeeId= 1,
                 RoleId= 1,
                },

                new EmployeeRole
                {
                 EmployeeId= 2,
                 RoleId= 2,
                },
                new EmployeeRole
                {
                 EmployeeId= 2,
                 RoleId= 10,
                },
                new EmployeeRole
                {
                 EmployeeId= 3,
                 RoleId= 4,
                },
                new EmployeeRole
                {
                 EmployeeId= 3,
                 RoleId= 11,
                },
                new EmployeeRole
                {
                 EmployeeId= 4,
                 RoleId= 3,
                },
                new EmployeeRole
                {
                 EmployeeId= 5,
                 RoleId= 9,
                },
                new EmployeeRole
                {
                 EmployeeId= 6,
                 RoleId= 5,
                },
                new EmployeeRole
                {
                 EmployeeId= 7,
                 RoleId= 7,
                },
                new EmployeeRole
                {
                 EmployeeId= 8,
                 RoleId= 12,
                },
            };

            builder.Entity<EmployeeRole>().HasData(employeeRoles);

            var roles = new List<Role>
            {
                new Role
                {
                 Id = 1,
                 Description = "CEO",
                },
                new Role
                {
                 Id = 2,
                 Description = "Assistant",
                },
                new Role
                {
                 Id = 3,
                 Description = "Lead Developer",
                },
                new Role
                {
                 Id = 4,
                 Description = "Developer",
                },
                new Role
                {
                 Id = 5,
                 Description = "Network Developer",
                },
                new Role
                {
                 Id = 6,
                 Description = "HR",
                },
                new Role
                {
                 Id = 7,
                 Description = "Lead Researcher",
                },
                new Role
                {
                 Id = 8,
                 Description = "IT Researcher",
                },
                new Role
                {
                 Id = 9,
                 Description = "Lead Communication",
                },
                new Role
                {
                 Id = 10,
                 Description = "Communication",
                },
                new Role
                {
                 Id = 11,
                 Description = "Lead Marketing",
                },
                new Role
                {
                 Id = 12,
                 Description = "Marketing",
                },
                new Role
                {
                 Id = 13,
                 Description = "IT support",
                },

            };

            builder.Entity<Role>().HasData(roles);
        }
    }
}