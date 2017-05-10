using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel
{
    public class SMSModelBaseClass
    {
        [StringLength(128)]
        [Column(TypeName ="nvarchar")]
        [ScaffoldColumn(false)]
        public string CreateBy { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime? CreateDate { get; set; }
        
        [StringLength(128)]
        [Column(TypeName = "nvarchar")]
        [ScaffoldColumn(false)]
        public string ModifyBy { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime? ModifyDate { get; set; }

    }
}
