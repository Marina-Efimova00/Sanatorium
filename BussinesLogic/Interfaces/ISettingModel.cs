using BussinesLogic.BindingModel;
using BussinesLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinesLogic.Interfaces
{
    public interface ISettingModel
    {
        List<SettingViewModel> Read(SettingBindingModel model);
        void CreateOrUpdate(SettingBindingModel model);
    }
}
