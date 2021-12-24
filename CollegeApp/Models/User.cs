using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeApp.Models
{
    public class User
    {
        public User(int id, string name, string lname, int yearOfBirth, bool isLog)
        {
            Id = id;
            Name = name;
            Lname = lname;
            YearOfBirth = yearOfBirth;
            IsLog = isLog;
        }

        public User()
        {

        }

        //public static List<User> listOfUsers = new List<User>();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lname { get; set; }
        public int YearOfBirth { get; set; }
        public bool IsLog { get; set; }



    }
}