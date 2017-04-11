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
    public class ClassRoom:SMSModelBaseClass
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string RoomType { get; set; }

        [Required]
        public Boolean Sharable { get; set; }

        public int Capacity { get; set; }

        public Status Status { get; set; }
    }
}
