using CollegeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CollegeApp.Controllers.api
{
    public class StudentController : ApiController
    {

        // GET: api/Student
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(Student.listOfStudents);

            }
            catch
            {
                return Ok("Student not found");
            }
        }

        // GET: api/Student/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Student byId =  Student.listOfStudents.Find(item => item.id == id);

                return Ok(byId);

            }
            catch
            {
                return Ok("Student not found");

            }
        }

        // POST: api/Student //add
        public IHttpActionResult Post([FromBody] Student value)
        {
            try
            {
                Student.listOfStudents.Add(value);
                return Ok(value);

            }
            catch
            {
                return Ok("Student not added");

            }
        }
        // PUT: api/Student/5 // update
        public IHttpActionResult Put(int id, [FromBody] Student value)
        {
            try
            {
                Student studentToUpdate = Student.listOfStudents.Find(item => id == item.id);
                 Student.listOfStudents.IndexOf(studentToUpdate);
                 Student.listOfStudents[ Student.listOfStudents.IndexOf(studentToUpdate)].fullName = value.fullName;
                 Student.listOfStudents[ Student.listOfStudents.IndexOf(studentToUpdate)].grade = value.grade;
                 Student.listOfStudents[ Student.listOfStudents.IndexOf(studentToUpdate)].birthYear = value.birthYear;
                 Student.listOfStudents[ Student.listOfStudents.IndexOf(studentToUpdate)].grade = value.grade;
                return Ok( Student.listOfStudents);

            }
            catch
            {
                return Ok("Student not update");

            }
        }

        // DELETE: api/Student/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Student.listOfStudents.Remove(Student.listOfStudents.Find(item => item.id == id));
                return Ok(Student.listOfStudents);

            }
            catch
            {
                return Ok("Student not Deleted");

            }
        }
    }


}
