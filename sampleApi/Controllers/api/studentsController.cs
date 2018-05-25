using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using sampleApi.Models;

namespace sampleApi.Controllers.api
{
    public class studentsController : ApiController
    {

        //ApplicationDbContext -> connection to db
        private ApplicationDbContext _context;
        public studentsController()
        {
            _context = new ApplicationDbContext();
        }
        //ApplicationDbContext -> connection to db




        //GET
        // localhost/api/students
        public IEnumerable<Students> GetStudents()
        {
            return _context.Students.ToList();
        }

        //localhost/api/students/{id}
        //localhost/api/students/1
        public Students GetStudents(int id)
        {
            var student = _context.Students.Single(x => x.Id == id);
            if (student == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return student;
        }

        //GET


        //POST localhost/api/students
        [HttpPost]
        public Students CreateStudents(Students students)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            _context.Students.Add(students);
            _context.SaveChanges();
            return students;
        }
        //POST localhost/api/students


        //PUT localhost/api/students/{id}
        //PUT localhost/api/students/1
        [HttpPut]
        public void UpdateStudent(int id, Students students)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var studentInDb = _context.Students.Single(x => x.Id == id);
            studentInDb.Age = students.Age;
            studentInDb.FullName = students.FullName;
            _context.SaveChanges();

        }
        //PUT localhost/api/students/{id}
        //PUT localhost/api/students/1


        //DELETE localhost/api/students/{id}
        //DELETE localhost/api/students/1
        [HttpDelete]
        public void UpdateStudent(int id)
        {
            var studentInDb = _context.Students.SingleOrDefault(x => x.Id == id);
            if (studentInDb == null)
            {
                throw  new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Students.Remove(studentInDb);
            _context.SaveChanges();
        }
        //DELETE localhost/api/students/{id}
        //DELETE localhost/api/students/1



    }
}
