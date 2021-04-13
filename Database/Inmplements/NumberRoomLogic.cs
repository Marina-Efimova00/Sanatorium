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
    public class NumberRoomLogic: INumberRoomModel
    {
        public void CreateOrUpdate(NumberRoomBindingModel model)
        {
            using (var context = new Database())
            {
                NumberRoom element = context.NumberRooms.FirstOrDefault(rec => rec.Number == model.Number && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть номер с таким номером");
                }
                if (model.Id.HasValue)
                {
                    element = context.NumberRooms.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new NumberRoom();
                    context.NumberRooms.Add(element);
                }
                element.Number = model.Number;
                element.Type = model.Type;
                element.Floor = model.Floor;
                element.Price = model.Price;
                context.SaveChanges();
            }
        }
        public void Delete(NumberRoomBindingModel model)
        {
            using (var context = new Database())
            {
                NumberRoom element = context.NumberRooms.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.NumberRooms.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        public List<NumberRoomViewModel> Read(NumberRoomBindingModel model)
        {
            using (var context = new Database())
            {
                return context.NumberRooms
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new NumberRoomViewModel
                {
                    Id = rec.Id,
                    Number = rec.Number,
                    Type = rec.Type,
                    Floor = rec.Floor,
                    Price = rec.Price,
                })
                .ToList();
            }
        }
    }
}
