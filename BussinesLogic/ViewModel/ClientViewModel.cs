using BussinesLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BussinesLogic.ViewModel
{
    public class ClientViewModel
    {
        public int? Id { get; set; }
        [DisplayName("ФИО")]
        public string FIO { get; set; }
        [DisplayName("Дата рождения")]
        public DateTime DateBirthday { get; set; }
        [DisplayName("Город")]
        public string City { get; set; }
        [DisplayName("Место рождения")]
        public string PlaceResident { get; set; }
        [DisplayName("Телефон")]
        public int Phone { get; set; }
        [DisplayName("Тип документа")]
        public string TypeDocument { get; set; }
        [DisplayName("Серия")]
        public int Series { get; set; }
        [DisplayName("Номер документа")]
        public int NumberDocument { get; set; }
        [DisplayName("Выдан")]
        public string Issued { get; set; }
        public virtual List<SettingViewModel> Settlings { get; set; }
    }
}
