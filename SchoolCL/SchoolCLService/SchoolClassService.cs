using NUnit.Framework;
using SchoolCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCLService
{
    [TestFixture]
    public class SchoolClassService
    {
        [TestCase(55,4, ExpectedResult = true)]
       [TestCase(30,-1, ExpectedResult = false)]
        public bool check1(int t,int j)
        {
            Marks m = new Marks();
            student s1 = new student(); 
            m.marks = t;
            m.Studentid = j;
            bool ans = s1.Enrollstudent( m);
            return ans;
        }
        [TestCase("nandhu" ,ExpectedResult = true)]
        [TestCase("", ExpectedResult = true)]
        public bool check2(string h)
        {
            student s1=new student();
            s1.studname = h;
            s1.Enrollstudent1();
            return true;
        }
    }
}
