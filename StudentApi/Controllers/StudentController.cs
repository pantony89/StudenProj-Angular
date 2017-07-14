using StudentApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StudentApi.Controllers
{
    [EnableCors("http://localhost:55079", "*","*")]
    public class StudentController : ApiController
    {
        StudentRepository STR = new StudentRepository(new StudentDbContext());

        // GET: api/Student
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            try
            {
                return STR.GetAll();

            }
            catch 
            {
                throw;
            }
        }

        public IEnumerable<Student> Get(string search)
        {
            try
            {
                return STR.Search(search);
            }
            catch
            {
                throw;
            }

        }

        // GET: api/Student/5
        public Student Get(int id)
        {
            try
            {
                var result = STR.GetSingleRecord(id);
                return result;
            }
            catch
            {
                throw;
            }
        }

        // POST: api/Student
        [HttpPost]
        public HttpResponseMessage Post([FromBody]Student value)
        {
            try
            {        
                STR.Insert(new Student() {
                    FirstName = value.FirstName,
                    LastName = value.LastName,
                                   
                });
                return Request.CreateResponse(HttpStatusCode.OK,STR.SaveChanges(),"Success");
            }
            catch
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotModified,"something wrong with your post call");
            }
        
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
