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
   public class Ward : SMSModelBaseClass
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        public int ConstituencyId { get; set;  }

        public virtual Constituency Constituency { get; set; }

        public virtual List<StudentDetails> StudentDetails { get; set;}

        public virtual List<Parent> Parent { get; set;  }

        public virtual List<StaffDetails> StaffDetails { get; set; }
    }
}
