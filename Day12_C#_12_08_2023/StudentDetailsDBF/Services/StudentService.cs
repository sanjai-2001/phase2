using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentDetails.Global_Exception;
using StudentDetails.Services.Interfaces;
using StudentDetailsDBF.Models;

namespace StudentDetails.Services
{
    public class StudentService : IStudent
    {
        public PayodaStudentMgmtContext? _studentContext;

        public StudentService(PayodaStudentMgmtContext studentContext)
        {
            _studentContext = studentContext;
        }

        public async Task<List<Student>> AddStudent(Student student)
        {
            _studentContext.Students.Add(student);  
            await _studentContext.SaveChangesAsync();
            return await _studentContext.Students.ToListAsync();

        }

        public async Task<List<Student>> DeleteStudent(int rollno)
        {
            Student rstudent = await _studentContext.Students.FindAsync(rollno);
            if (rstudent == null)
            {
                throw new Exception(StudentDetailsExceptions.ExceptionMessages[0]);
            }
            else
            {

                _studentContext.Remove(rstudent);
                await _studentContext.SaveChangesAsync();
                // rstudent= await _studentContext.Students.FindAsync(rollno);
                return await _studentContext.Students.ToListAsync();
                //return await _studentContext.Students.ToListAsync();
            }
        }
          
        public  async Task<List<Student>> GetAllStudents()
        {
           var response = await _studentContext.Students.ToListAsync();
            return response;
        }

        public async Task<Student> GetStudentsByRollno(int rollno)
        {
          var student=  await _studentContext.Students.FindAsync(rollno);
           if(student == null) 
            {
                throw new Exception(StudentDetailsExceptions.ExceptionMessages[0]);
            }
            else
            {
                return student;
            }
            
        }

        public async Task<List<Student>> UpdateStudent(int rollno, Student student)
        {
            Student rstudent = await _studentContext.Students.FindAsync(rollno);
            if (rstudent == null)
            {
                throw new Exception(StudentDetailsExceptions.ExceptionMessages[0]);
            }
            else
            {
                rstudent.Studname = student.Studname;
                rstudent.Addr = student.Addr;
                rstudent.Phno=student.Phno; 
                await _studentContext.SaveChangesAsync();
                // rstudent= await _studentContext.Students.FindAsync(rollno);
               return await _studentContext.Students.ToListAsync();
                //return await _studentContext.Students.ToListAsync();
            }
        }
    }
}
