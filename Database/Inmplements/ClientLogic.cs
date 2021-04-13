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
    public class ClientLogic: IClientModel
    {
        public void CreateOrUpdate(ClientBindingModel model)
        {
            using (var context = new Database())
            {
                Client element = context.Clients.FirstOrDefault(rec => rec.FIO == model.FIO && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть клиент с таким ФИО");
                }
                if (model.Id.HasValue)
                {
                    element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Client();
                    context.Clients.Add(element);
                }
                element.FIO = model.FIO;
                element.DateBirthday = model.DateBirthday;
                element.City = model.City;
                element.PlaceResident = model.PlaceResident;
                element.Phone = model.Phone;
                element.TypeDocument = model.TypeDocument;
                element.Series = model.Series;
                element.NumberDocument = model.NumberDocument;
                element.Issued= model.Issued;
                context.SaveChanges();
            }
        }
        public void Delete(ClientBindingModel model)
        {
            using (var context = new Database())
            {
                Client element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Clients.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        public List<ClientViewModel> Read(ClientBindingModel model)
        {
            using (var context = new Database())
            {
                return context.Clients
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new ClientViewModel
                {
                    Id = rec.Id,
                    FIO = rec.FIO,
                    DateBirthday = rec.DateBirthday,
                    City = rec.City,
                    PlaceResident = rec.PlaceResident,
                    Phone = rec.Phone,
                    TypeDocument = rec.TypeDocument,
                    Series = rec.Series,
                    NumberDocument = rec.NumberDocument,
                    Issued = rec.Issued,
                })
                .ToList();
            }
        }
    }
}
