using StudentDetails.Models;

namespace StudentDetails.Services.Interfaces
{
    public interface IStudent
    {

         Task<List<Student>> GetAllStudents();
        Task<Student> GetStudentsByRollno(int rollno);
        Task<List<Student>> AddStudent(Student student);
        Task<List<Student>> UpdateStudent(int rollno,Student student);
        Task<List<Student>> DeleteStudent(int rollno);  

    }
}
