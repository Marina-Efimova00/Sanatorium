using BussinesLogic.Interfaces;
using Database.Inmplements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace Sanatorium
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<AutorizationForm>());
        }
        public static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<INumberRoomModel, NumberRoomLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IClientModel, ClientLogic>(new  HierarchicalLifetimeManager());
            currentContainer.RegisterType<ISettingModel, SettilingLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IUserLogic, UserLogic>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
