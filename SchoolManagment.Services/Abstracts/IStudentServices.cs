using SchoolManagment.Data.Entities;

namespace SchoolManagment.Services.Abstracts
{
    public interface IStudentServices
    {
        Task<IEnumerable<Student>> GetStudentsAysnc();
        Task<Student> GetStudentByIdAysnc(int id);
        Task<Student> GetStudentByNameAysnc(string name);

        Task<string> AddStudentAsync(Student student);
        Task<string> EditStudentAsync(Student student);
        Task<string> DeleteStudentAsync(Student student);


        Task<bool> IsNameExist(string name);
        Task<bool> IsNameExistIncludeSelf(string name, int Id);





    }
}
