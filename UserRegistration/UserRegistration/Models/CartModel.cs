using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegistration.Models
{
    public class CartModel
    {
        [Key]
        public int cartid { get; set; }
        [Required]
        [Column(TypeName = "varchar(2)")]
        public string ctype { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string cname { get; set; }        
        [Required]
        public double cprice { get; set; }
    }
}
