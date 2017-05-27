using SchoolManagementSystemModel.Enums;
using SchoolManagementSystemModel.School;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.Student
{
    public class Parent
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }
        
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }
        
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string EmailAddress { get; set; }
        
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string PhoneNo { get; set; }

        public int PostalAddress { get; set; }

        public int PostalCodeId { get; set; }

        public virtual PostalCode PostalCode { get; set; }

        public int WardId { get; set; }

        public virtual Ward Ward { get; set; }

        public Gender Gender { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Occupation { get; set; }

        public virtual List<StudentParent> StudentParents { get; set; }
    }
}
