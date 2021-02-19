using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Type { get; set; }
        
        [Required]
        public string Comment { get; set; }
       
        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage = "Value out or range ")]
        public double Amount { get; set; }
    }
}
