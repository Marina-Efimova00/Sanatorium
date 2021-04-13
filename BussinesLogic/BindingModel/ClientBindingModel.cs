using BussinesLogic.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinesLogic.BindingModel
{
    public class ClientBindingModel
    {
        public int? Id { get; set; }
        public string FIO { get; set; }
        public DateTime DateBirthday { get; set; }
        public string City { get; set; }
        public string PlaceResident { get; set; }
        public int Phone { get; set; }
        public string TypeDocument { get; set; }
        public int Series { get; set; }
        public int NumberDocument { get; set; }
        public string Issued { get; set; }
        public virtual List<SettingBindingModel> Settlings { get; set; }
    }
}
