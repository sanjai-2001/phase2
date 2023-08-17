using JWT_Auth.Models;
using JWT_Auth.Services.Interface;
using Microsoft.EntityFrameworkCore;
using StudentDetails.GlobalExceptions;

namespace JWT_Auth.Services
{
    public class StudentService:IStudent
    {
        public PayodaStudentContext? _studentContext;

        public StudentService(PayodaStudentContext studentContext)
        {
            this._studentContext = studentContext;
        }

        public async Task<List<Student>> AddStudent(Student student)
        {
            _studentContext.Students.Add(student);
            await _studentContext.SaveChangesAsync();
            return await _studentContext.Students.ToListAsync();

        }

        public async Task<List<Student>> DeleteStudent(int rollno)
        {
            var student = await _studentContext.Students.FindAsync(rollno);
            if (student == null)
            {
                throw new Exception(StudentDetailsExceptions.ExceptionMessages[0]);
            }
            else
            {
                _studentContext.Students.Remove(student);
                await _studentContext.SaveChangesAsync();
                var response = await _studentContext.Students.ToListAsync();
                return response;
            }
        }

        public async Task<List<Student>> GetAllStudents()
        {   
            var students = await _studentContext.Students.ToListAsync();
            return students;
        }

        public async Task<Student> GetStudentByRollno(int rollno)
        {
            var student = await _studentContext.Students.FindAsync(rollno);
            if (student == null)
            {
                throw new Exception(StudentDetailsExceptions.ExceptionMessages[0]);
            }
            else
            {
                return student;
            }
        }



        public async Task<Student> UpdateStudent(int rollno, Student student)
        {
            Student? rstudent = await _studentContext.Students.FindAsync(rollno);
            if (rstudent == null)
            {
                throw new Exception(StudentDetailsExceptions.ExceptionMessages[0]);
            }
            else
            {
                rstudent.Studentame = student.Studentame;
                rstudent.Addr = student.Addr;
                rstudent.Phno = student.Phno;
                await _studentContext.SaveChangesAsync();
                
                return await _studentContext.Students.FindAsync(rollno);
            }
        }

    }
}
