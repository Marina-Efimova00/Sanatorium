using System;
using System.Collections.Generic;
using System.Text;

namespace BussinesLogic.BindingModel
{
    public class SettingBindingModel
    {
        public int? Id { get; set; }
        public int CountPeople { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DateDeparture { get; set; }
        public string ClientId { get; set; }
        public string NumberRoomId { get; set; }
        public virtual List<ClientBindingModel> Clients { get; set; }
        public virtual List<NumberRoomBindingModel> NumberRooms { get; set; }
    }
}
