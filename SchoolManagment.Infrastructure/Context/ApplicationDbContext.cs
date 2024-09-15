using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolManagment.Data.Entities;
using SchoolManagment.Data.Entities.Identity;

namespace SchoolManagment.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {



        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<DepartmetSubject> DepartmetSubjects { get; set; }



    }
}

