using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [Required]
        public int CountPeople { get; set; }
        [Required]
        public DateTime ArrivalDate { get; set; }
        [Required]
        public DateTime DateDeparture { get; set; }
        [Required]
        public string ClientId { get; set; }
        [Required]
        public string NumberRoomId { get; set; }
        public virtual NumberRoom NumberRoom { get; set; }
        public virtual Client Client { get; set; }
    }
}
