using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.School
{
    public class SchoolDetails : SMSModelBaseClass
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        [StringLength(15)]
        [Column(TypeName = "varchar")]
        public string PhoneNumber { get; set; }

        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string emailAddress { get; set; }

        [StringLength(15)]
        [Column(TypeName = "varchar")]
        public string MobileNumber { get; set; }

        public int boxNumber { get; set; }

        public int zipCode { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string town { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string ward { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string county { get; set; }

        public byte[] Logo { get; set; }

        public string createdBy { get; set; }

        public DateTime createdDate { get; set; }

        public string modifyBy { get; set; }

        public DateTime modifyDate { get; set; }
    }
}
