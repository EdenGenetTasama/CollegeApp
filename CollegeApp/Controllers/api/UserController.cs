using CollegeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CollegeApp.Controllers.api
{
    public class UserController : ApiController
    {
        public static List<User> listOfUsers = new List<User>();

        private void UsersArray()
        {
            User[] bookArray = new User[]
           {
                new User(1, "PersonOne" , "lastNameOne" , 1996 , true),
                new User(2, "PersonTwo" , "lastNameTwo" , 1998 , false),
                new User(3, "PersonThree" , "lastNameThree" , 2000, false),
                new User(4, "PersonFour" , "lastNameFour" , 2001 , true),
                new User(5, "PersonFive" , "lastNameFive" , 2008 , true),
                new User(6, "PersonSix" , "lastNameSix" , 2009 , false),
                new User(7, "PersonSeven" , "lastNameSeven" , 2010 , true),
                new User(8, "PersonEigth" , "lastNameEigth" , 2011 , false)
           };

            listOfUsers.AddRange(bookArray);
        }

        // GET: api/User
        public IHttpActionResult Get()
        {
            UsersArray();
            return Ok(listOfUsers);
        }

        // GET: api/User/5    /// get by id
        public IHttpActionResult Get(int id)
        {
            UsersArray();
            User getById = listOfUsers.Find(item => item.Id == id);
            return Ok(getById);
        }

        // POST: api/User ////add new User
        public IHttpActionResult Post([FromBody] User value)
        {
            listOfUsers.Add(value);
            return Ok(value);
        }

        // PUT: api/User/5    /// update User info
        public IHttpActionResult Put(int id, [FromBody] User value)
        {
            UsersArray();
            User userToUpdate = listOfUsers.Find(item => id == item.Id);
            listOfUsers.IndexOf(userToUpdate);
            listOfUsers[listOfUsers.IndexOf(userToUpdate)].Name = value.Name;
            listOfUsers[listOfUsers.IndexOf(userToUpdate)].Lname = value.Lname;
            listOfUsers[listOfUsers.IndexOf(userToUpdate)].YearOfBirth = value.YearOfBirth;
            listOfUsers[listOfUsers.IndexOf(userToUpdate)].IsLog = value.IsLog;
            return Ok(listOfUsers);
        }

        // DELETE: api/User/5
        public IHttpActionResult Delete(int id)
        {
            listOfUsers.Remove(listOfUsers.Find(item => id == item.Id));
            return Ok("Removed");
        }
    }
}
