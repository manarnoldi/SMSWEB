using SchoolManagementSystemModel.Academics;
using SchoolManagementSystemModel.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.School
{
    public class StaffDetails :SMSModelBaseClass
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string StaffNo { get; set; }

        [Required]
        [StringLength(15)]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }
        
        [StringLength(15)]
        [Column(TypeName = "varchar")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(15)]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }
        
        public int IdNumber { get; set; }
        
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string PhoneNumber { get; set; }
        
        public int WardId { get; set; }

        public virtual Ward Ward { get; set; }
        
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Religion { get; set; }
        
        public Gender Gender { get; set; }
        
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Email { get; set; }

        public ContractType ContractType { get; set; }

        public StaffType StaffType { get; set; }

        public DateTime DateOfEmployment { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Designation { get; set; }

        public Status Status { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string PostalAddress { get; set; }

        [StringLength(300)]
        [Column(TypeName ="varchar")]
        public string StaffImageUrl { get; set; }
        
        public virtual PostalCode PostalCode { get; set; }

        public virtual List<ClassHead> ClassHeads { get; set; }

        public virtual List<Department> Departments { get; set; }

        public virtual List<StaffSubject> StaffSubjects { get; set; }
    }
}
