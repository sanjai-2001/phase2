using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using StudentDetails.Services.Interfaces;
using StudentDetailsDBF.Models;

namespace StudentDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IStudent _student;


        public StudentController(IStudent student)
        {
            _student = student;
        }
        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            var students = await _student.GetAllStudents();
            if (students == null)
            {
                return NotFound("Not Found");
            }
            else
            {
                return Ok(students);
            }
        }

        [HttpGet("{rollno}") ]
        
        public async Task<ActionResult<Student>> GetStudentByRollno(int rollno)
        {
            Student student;
            try
            {
                student = await _student.GetStudentsByRollno(rollno);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }            
                return Ok(student);
            
        }

        [HttpPost]
        public async Task<ActionResult<Student>> AddStudent(Student student)
        {
            var students = await _student.AddStudent(student);
            return Ok(students);
        }

        [HttpPut]
        public async Task<ActionResult<List<Student>>> UpdateStudent(int rollno,Student student)
        {
          
            try
            {
              var  rstudents = await _student.UpdateStudent(rollno, student);
                return Ok(rstudents);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            //return Ok(student);

        }
        [HttpDelete]
        public async Task<ActionResult<List<Student>>> DeleteStudent(int rollno)
        {

            try
            {
                var rstudents = await _student.DeleteStudent(rollno);
                return Ok(rstudents);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            //return Ok(student);

        }
    }
}
