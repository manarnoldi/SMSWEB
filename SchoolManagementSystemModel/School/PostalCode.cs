using SchoolManagementSystemModel.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.School
{
   public  class PostalCode : SMSModelBaseClass
    {
        public int Id { get; set; }

        public int Code { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string PostalName { get; set; }

        public virtual List<SchoolDetails> SchoolDetails { get; set; }

        public virtual List<StaffDetails> StaffDetails { get; set; }

        public virtual List<StudentDetails> StudentDetails { get; set; }

        public virtual List<Parent> Parents { get; set; }
    }
}
