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
        [Index("IX_SchoolDetails_Name",IsUnique = true)]
        public string Name { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string PhoneNumber { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        [Index("IX_SchoolDetails_Email", IsUnique = true)]
        public string EmailAddress { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string MobileNumber { get; set; }

        public int PostalAddress { get; set; }

        public int PostalCodeId { get; set; }

        public virtual PostalCode PostalCode { get; set; }

        public int WardId { get; set; }

        public virtual Ward Ward { get; set; }

        [StringLength(300)]
        [Column(TypeName = "varchar")]
        public string SchoolLogoUrl { get; set; }
    }
}
