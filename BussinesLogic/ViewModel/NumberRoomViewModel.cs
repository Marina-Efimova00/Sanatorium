using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BussinesLogic.ViewModel
{
    public class NumberRoomViewModel
    {
        public int? Id { get; set; }
        [DisplayName("№")]
        public int Number { get; set; }
        [DisplayName("Тип")]
        public string Type { get; set; }
        [DisplayName("Этаж")]
        public int Floor { get; set; }
        [DisplayName("Цена")]
        public double Price { get; set; }
        public virtual List<SettingViewModel> Settlings { get; set; }
    }
}
