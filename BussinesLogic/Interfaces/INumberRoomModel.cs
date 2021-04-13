using BussinesLogic.BindingModel;
using BussinesLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinesLogic.Interfaces
{
    public interface INumberRoomModel
    {
        List<NumberRoomViewModel> Read(NumberRoomBindingModel model);
        void CreateOrUpdate(NumberRoomBindingModel model);
        void Delete(NumberRoomBindingModel model);
    }
}
