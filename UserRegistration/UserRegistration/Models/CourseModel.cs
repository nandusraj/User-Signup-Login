using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegistration.Models
{
    public class CourseModel
    {
        [Key]
        public int cid { get; set; }
        [Required]
        [Column(TypeName ="varchar(2)")]
        public string type { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string name { get; set; }
        [Required]        
        public int duration { get; set; }
        [Required]
        public double price { get; set; }

    }
}
