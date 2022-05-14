using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Students.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public static List<Student> students = new List<Student>()
        {
        new Student { id= 1, name= "leah", active= false, marksAvg= 100, proffessionId=1 , year=Year.a,tests=new List<Test>{ new Test  { id = 1, description = "WEB", mark = 150 } }  },
        new Student { id= 2, name= "rachel", active= false, marksAvg= 80 ,proffessionId= 1,year= Year.a,tests=new List<Test>{ new Test  { id = 1, description = "WEB", mark = 150 } }},
        new Student { id= 3, name= "ruth", active= true, marksAvg= 70,proffessionId= 1 ,year= Year.b,tests=new List<Test>{ new Test  { id = 1, description = "WEB", mark = 150 } }}
        };
        // GET: api/<StudentController>

        [HttpGet]
        public List<Student> Get()
        {
            return students;
        }

        // GET api/<StudentController>/5
        [HttpGet("{active}")]
        public List<Student> Get(bool active)
        {
           if (active)  
             return students.FindAll(x => x.active);
           return students;     
            
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] Student st)
        {
         students.Add(st);
        }

        // PUT api/<StudentController>/5
        [HttpPut]
        public void Put( [FromBody] Student st)
        {
            Student originStud= students.Find(x => x.id == st.id);
            int index= students.IndexOf(originStud);
            students[index] = st;
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{index}")]
        public bool Delete(int index)
        {
            try { 
            students.RemoveAt(index);
            }
            catch
            {
                throw new Exception("error");
            }
            return true;
        }
    }
}
