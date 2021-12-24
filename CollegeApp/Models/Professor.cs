using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeApp.Models
{
    public class Professor
    {
        public int id;
        public string fullName;
        public int pay;
        public int yearsOfWork;
        public string[] topic;

        public Professor(int id, string fullName, int pay, int yearsOfWork, string[] topic)
        {
            this.id = id;
            this.fullName = fullName;
            this.pay = pay;
            this.yearsOfWork = yearsOfWork;
            this.topic = topic;
        }
        public static List<Professor> professorList = new List<Professor>();
    }
}