using BussinesLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        public string FIO { get; set; }
        [Required]
        public DateTime DateBirthday { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PlaceResident { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public string TypeDocument { get; set; }
        [Required]
        public int Series { get; set; }
        [Required]
        public int NumberDocument { get; set; }
        [Required]
        public string Issued { get; set; }
        public virtual List<Setting> Settlings { get; set; }
    }
}
