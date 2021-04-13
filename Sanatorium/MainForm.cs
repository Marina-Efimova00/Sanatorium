using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Sanatorium
{
    public partial class MainForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void Клиенты_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<ClientForm>();
            form.ShowDialog();
        }

        private void Номера_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<RoomForm>();
            form.ShowDialog();
        }

        private void Заселение_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<SettingForm>();
            form.ShowDialog();
        }
    }
}
