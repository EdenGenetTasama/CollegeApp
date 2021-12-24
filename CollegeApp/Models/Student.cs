using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeApp.Models
{
    public class Student
    {
        public int id;
        public string fullName;
        public int grade;
        public int birthYear;
        public string[] grades;

        public Student(int id, string fullName, int grade, int birthYear, string[] grades)
        {
            this.id = id;
            this.fullName = fullName;
            this.grade = grade;
            this.birthYear = birthYear;
            this.grades = grades;
        }

        public static List<Student> listOfStudents = new List<Student>();

    }
}