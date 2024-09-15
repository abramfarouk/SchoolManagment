using Microsoft.EntityFrameworkCore;
using SchoolManagment.Data.Entities;
using SchoolManagment.Infrastructure.Abstracts;
using SchoolManagment.Services.Abstracts;

namespace SchoolManagment.Services.Implemetation
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepository studentRepository;
        public StudentServices(IStudentRepository _studentRepository)
        {
            studentRepository = _studentRepository;
        }

        public async Task<string> AddStudentAsync(Student student)
        {

            try
            {
                await studentRepository.AddAsync(student);

                return "Success";
            }
            catch
            {

                return $"Fk";
            }

        }
        public async Task<string> DeleteStudentAsync(Student student)
        {
            await studentRepository.DeleteAsync(student);
            return "Delete";
        }

        public async Task<string> EditStudentAsync(Student student)
        {
            try
            {
                await studentRepository.UpdateAsync(student);
                return "Updated";
            }
            catch
            {
                return "FK";
            }

        }
        public async Task<Student> GetStudentByIdAysnc(int id)
        {
            var student = await studentRepository.GetTableNoTracking().Include(d => d.Department)
                .Where(st => st.StudID == id).FirstOrDefaultAsync();
            return student;
        }

        public async Task<Student> GetStudentByNameAysnc(string name)
        {
            var StdName = await studentRepository.GetTableNoTracking()
                .Where(st => st.Name == name).FirstOrDefaultAsync();

            return StdName;
        }

        public async Task<IEnumerable<Student>> GetStudentsAysnc()
        {
            return await studentRepository.GetStudentsAsync();
        }
        public async Task<bool> IsNameExist(string name)
        {
            var SameNameStd = await studentRepository.GetTableNoTracking()
                           .Where(st => st.Name == name).FirstOrDefaultAsync();
            if (SameNameStd == null) return false;
            return true;

        }
        public async Task<bool> IsNameExistIncludeSelf(string name, int Id)
        {
            var SameNameStd = await studentRepository.GetTableNoTracking()
                          .Where(st => st.Name == name & !st.StudID.Equals(Id)).FirstOrDefaultAsync();
            if (SameNameStd == null) return false;
            return true;
        }
    }
}
