using CollegeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
listOfStudents
namespace CollegeApp.Controllers.api
{
    public class ProfessorController : ApiController
    {


        // GET: api/Professor
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(Professor.professorList);

            }
            catch
            {
                return Ok("Professor not found");
            }
        }

        // GET: api/Professor/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Professor byId = Professor.professorList.Find(item => item.id == id);

                return Ok(byId);

            }
            catch
            {
                return Ok("Professor not found");

            }
        }

        // POST: api/Professor //add
        public IHttpActionResult Post([FromBody] Professor value)
        {
            try
            {
                Professor.professorList.Add(value);
                return Ok(value);

            }
            catch
            {
                return Ok("Student not added");

            }
        }
        // PUT: api/Professor/5 // update
        public IHttpActionResult Put(int id, [FromBody] Professor value)
        {
            try
            {
                Professor professorToUpdate = Professor.professorList.Find(item => id == item.id);
                Professor.professorList.IndexOf(professorToUpdate);
                Professor.professorList[Professor.professorList.IndexOf(professorToUpdate)].fullName = value.fullName;
                Professor.professorList[Professor.professorList.IndexOf(professorToUpdate)].pay = value.pay;
                Professor.professorList[Professor.professorList.IndexOf(professorToUpdate)].yearsOfWork = value.yearsOfWork;
                Professor.professorList[Professor.professorList.IndexOf(professorToUpdate)].topic = value.topic;
                return Ok(Professor.professorList);

            }
            catch
            {
                return Ok("professor not update");

            }
        }

        // DELETE: api/Professor/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Professor.professorList.Remove(Professor.professorList.Find(item => item.id == id));
                return Ok(Professor.professorList);

            }
            catch
            {
                return Ok("Professor not Deleted");

            }
        }
    }
}
