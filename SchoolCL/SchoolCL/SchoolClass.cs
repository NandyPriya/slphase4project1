using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCL
{
    public class SchoolClass
    {
        public string Classname { get; set; }
        public int Noofstudents { get; set; }
    }
    public class Marks
    {
        public int marks { get; set; }
        public int Subjectid { get; set; }
        public int Studentid { get; set; }
        
    }
    public class subject
    {
        public int Subjectid { get; set; }
        public string Subname { get; set; }
        public string Class { get; set; }
    }
    public class student
    { 
        public int Studentid { get; set; }
        public string studname { get; set; }
        public string Class { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public bool Enrollstudent(Marks m)
        {
            if (m.marks > 50&&m.Studentid>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Enrollstudent1()
        {
            if (studname != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
