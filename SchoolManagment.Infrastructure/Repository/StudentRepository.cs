using Microsoft.EntityFrameworkCore;
using SchoolManagment.Data.Entities;
using SchoolManagment.Infrastructure.Abstracts;
using SchoolManagment.Infrastructure.Data;
using SchoolManagment.Infrastructure.InfrastructureBases;

namespace SchoolManagment.Infrastructure.Repository
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        private readonly DbSet<Student> _students;

        public StudentRepository(ApplicationDbContext context) : base(context)
        {
            {
                _students = context.Set<Student>();
            }
        }

        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            return await _students.Include(d => d.Department).ToListAsync();
        }


    }

}


