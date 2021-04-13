using System;
using System.Collections.Generic;
using System.Text;

namespace BussinesLogic.BindingModel
{
    public class NumberRoomBindingModel
    {
        public int? Id { get; set; }
        public int Number { get; set; }
        public string Type { get; set; }
        public int Floor { get; set; }
        public double Price { get; set; }
        public int UserId { get; set; }
        public virtual List<SettingBindingModel> Settlings { get; set; }
    }
}
