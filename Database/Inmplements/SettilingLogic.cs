using BussinesLogic.BindingModel;
using BussinesLogic.Interfaces;
using BussinesLogic.ViewModel;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Inmplements
{
    public class SettilingLogic : ISettingModel
    {
        public void CreateOrUpdate(SettingBindingModel model)
        {
            using (var context = new Database())
            {
                Setting element = context.Settings.FirstOrDefault(rec => rec.NumberRoomId == model.NumberRoomId && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже номер занят");
                }
                if (model.Id.HasValue)
                {
                    element = context.Settings.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Setting();
                    context.Settings.Add(element);
                }
                element.CountPeople = model.CountPeople;
                element.ArrivalDate = model.ArrivalDate;
                element.DateDeparture = model.DateDeparture;
                element.ClientId = model.ClientId ;
                element.NumberRoomId = model.NumberRoomId ;
                context.SaveChanges();
            }
        }

        public List<SettingViewModel> Read(SettingBindingModel model)
        {
            using (var context = new Database())
            {
                return context.Settings
                .Where(rec => model == null || rec.Id == model.Id)
                .ToList()
                .Select(rec => new SettingViewModel
                {
                    Id = rec.Id,
                    CountPeople = rec.CountPeople,
                    ArrivalDate = rec.ArrivalDate,
                    DateDeparture = rec.DateDeparture,
                    ClientId = rec.ClientId,
                    NumberRoomId = rec.NumberRoomId,
                })
                .ToList();
            }
        }
    }
}
