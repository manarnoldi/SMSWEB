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

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string PhoneNumber { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string EmailAddress { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string MobileNumber { get; set; }

        public int PostalAddress { get; set; }

        public int PostalId { get; set; }

        public virtual PostalCode PostalCode { get; set; }

        public int CoutyWardId { get; set; }

        public virtual CountyWard CoutyWard { get; set; }

        public byte[] Logo { get; set; }
    }
}
