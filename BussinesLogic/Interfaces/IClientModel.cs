using BussinesLogic.BindingModel;
using BussinesLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinesLogic.Interfaces
{
    public interface IClientModel
    {
        List<ClientViewModel> Read(ClientBindingModel model);
        void CreateOrUpdate(ClientBindingModel model);
        void Delete(ClientBindingModel model);
    }
}
