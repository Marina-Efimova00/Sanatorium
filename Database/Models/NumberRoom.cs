using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.Models
{
    public class NumberRoom
    {
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Floor { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int UserId { get; set; }
        public virtual List<Setting> Settlings { get; set; }
    }
}
