using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentApi.Models
{
    public class studentDBInitializer: DropCreateDatabaseAlways<StudentDbContext>
    {
        protected override void Seed(StudentDbContext condext)
        {
            
                IList<Student> defaultData = new List<Student>();

                defaultData.Add(new Student() { FirstName = "Antony", LastName = "Pathinathan", DateOfCreated = DateTime.Now });
                defaultData.Add(new Student() { FirstName = "john", LastName = "117", DateOfCreated = DateTime.Now });

                foreach (Student std in defaultData)
                {
                    condext.Students.Add(std);
                }
                base.Seed(condext);
            
        }
    }
}