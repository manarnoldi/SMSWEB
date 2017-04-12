using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.Student
{
    public class StudentParent : SMSModelBaseClass
    {
        public int Id { get; set; }

        public int StudentDetailsId { get; set; }

        public virtual StudentDetails StudentDetails { get; set; }

        public int ParentId { get; set; }

        public virtual Parent Parent { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName ="varchar")]
        public string Relationship { get; set; }
    }
}
