using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentApi.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }

        public DateTime DateOfCreated
        {
            get
            {
                return (this.dateCreated == default(DateTime))
                   ? this.dateCreated = DateTime.Now
                   : this.dateCreated;
            }

            set { this.dateCreated = value; }
        }

        private DateTime dateCreated = default(DateTime);
    }
}