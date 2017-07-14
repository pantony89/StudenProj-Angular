using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StudentApi.Models
{
    public class StudentRepository : IRepository<Student>
    {
        private StudentDbContext _sdx;

        public StudentRepository(StudentDbContext sdx)
        {
            _sdx = sdx;
        }

        //Delete a single record
        public bool DeleteRecord(int id)
        {
            try
            {
                var entity = _sdx.Students.Where(s => s.Id == id).FirstOrDefault();
                if (entity != null)
                {
                    _sdx.Students.Remove(entity);
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }

        //Get all the students
        public IQueryable<Student> GetAll()
        {
            try
            {
                var result= _sdx.Students.OrderByDescending(s => s.Id);
                return result;
            }
            catch(Exception ex)
            {

                throw ex;
            }
        }

        //Get single record of the student
        public Student GetSingleRecord(int id)
        {
            try
            {
                return _sdx.Students.Where(s => s.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Insert the collection of data
        public bool InsertCollection(ICollection<Student> ListOfStudent)
        {
            try
            {
                _sdx.Students.AddRange(ListOfStudent);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Insert single record  Method
        public bool Insert(Student data)
        {
            try
            {
                _sdx.Students.Add(data);
                
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public  bool SaveChanges()
        {
            try
            {
                return _sdx.SaveChanges() > 0;
            }
            catch
            {

                throw  ;
            }
           
        }


        //UpDate Student Method
        public bool Update(Student data)
        {
            try
            {
                _sdx.Entry(data).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Student Find(Student student)
        {
            if (student.Id!=null)
            {
                return _sdx.Students.Find(student.Id);
            }
            return null;
        }

        public IQueryable<Student> Search(string search)
        {
            var students = _sdx.Students;
            return students.Where(s=>s.FirstName.Contains(search));
        }
    }
}