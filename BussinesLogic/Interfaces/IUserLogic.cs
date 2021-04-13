using BussinesLogic.BindingModel;
using BussinesLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinesLogic.Interfaces
{
    public interface IUserLogic
    {
        List<UserViewModel> Read(UserBindingModel model);
    }
}
