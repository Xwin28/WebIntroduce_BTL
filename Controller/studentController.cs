using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Form.Controller
{
    public class studentController : ApiController
    {
        student[] students = new student[]
         {
             new student { StudentID = 1, FirstName = "Jishan", LastName = "Siddique" },
             new student { StudentID = 2, FirstName = "Bharat", LastName = "Darji" },
             new student { StudentID = 3, FirstName = "Ravi", LastName = "Mori" },
             new student { StudentID = 4, FirstName = "Jay", LastName = "Singh" }
         };

        public IEnumerable<student> GetStudents()
        {
            return students;
        }

        public IHttpActionResult GetStudentsJson()
        {
            //return students;
            return Ok(students);
        }

         

    }
}