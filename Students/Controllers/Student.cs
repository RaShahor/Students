
using System.Collections.Generic;

namespace Students.Controllers
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool active { get; set; }
        public float marksAvg { get; set; }
        public int proffessionId { get; set; }

        public  Year year { get; set; }

        public List<Test> tests { get; set; }
         
        //public Student(int i,string n,bool a,int pi,float mavg,Year y,List<Test> t)
        //{
        //     id = i; 
        //     name = n;
        //     active = a;
        //     marksAvg = mavg;
        //    proffessionId = pi;
        //     year =y;
        //     tests=t;
        //}
    }
}