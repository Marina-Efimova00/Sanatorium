using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BussinesLogic.ViewModel
{
    public class SettingViewModel
    {
        public int? Id { get; set; }
        [DisplayName("Количество людей")]
        public int CountPeople { get; set; }
        [DisplayName("Дата приезда")]
        public DateTime ArrivalDate { get; set; }
        [DisplayName("Дата выезда")]
        public DateTime DateDeparture { get; set; }
        [DisplayName("Клиент")]
        public string ClientId { get; set; }
        [DisplayName("Номер")]
        public string NumberRoomId { get; set; }

    }
}
