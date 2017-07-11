using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentApi.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext():base("StudentDbContext")
        {            
                Database.SetInitializer(new studentDBInitializer());
       
        }

        public DbSet<Student> Students { get; set; }
    }
}