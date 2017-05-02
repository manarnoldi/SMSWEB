using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.School
{
    public class ToDoList : SMSModelBaseClass
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Subject { get; set; }

        [Required]
        [StringLength(150)]
        [Column(TypeName = "varchar")]
        public string Content { get; set; }

        public DateTime ToDoDate { get; set; }

        public TaskStatus TaskStatus { get; set; }

        public int CalendarId { get; set; }

        public virtual Calendar Calendar { get; set; }
    }
}
