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
    public class StaffDetails
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string staffNo { get; set; }

        [Required]
        [StringLength(15)]
        [Column(TypeName = "varchar")]
        public string firstName { get; set; }
        
        [StringLength(15)]
        [Column(TypeName = "varchar")]
        public string middleName { get; set; }

        [Required]
        [StringLength(15)]
        [Column(TypeName = "varchar")]
        public string lastName { get; set; }
        
        public int idNumber { get; set; }
        
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string phoneNumber { get; set; }
        
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string ward { get; set; }
        
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string county { get; set; }
        
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string religion { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string staffType { get; set; }
        
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string gender { get; set; }
        
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string email { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string employmentType { get; set; }

        public DateTime dateOfEmployment { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Designation { get; set; }

        public Status Status { get; set; }

        public virtual List<ClassHead> ClassHeads { get; set; }
    }
}
