using BussinesLogic.BindingModel;
using BussinesLogic.Interfaces;
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
    public partial class SettingClientForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly ISettingModel logic;
        private readonly IClientModel logicC;
        private readonly INumberRoomModel logicN;
        private int? id;
        public SettingClientForm(ISettingModel logic, IClientModel logicC, INumberRoomModel logicN)
        {
            InitializeComponent();
            this.logic = logic;
            this.logicC = logicC;
            this.logicN = logicN;
        }

        private void SettingClentForm_Load(object sender, EventArgs e)
        {
            var list = logicC.Read(null);
            if (list != null)
            {
                comboBoxClient.DataSource = list;
                comboBoxClient.DisplayMember = "FIO";
                comboBoxClient.ValueMember = "Id";

            }
            var listNum = logicN.Read(null);
            if (listNum != null)
            {
                comboBoxNumber.DataSource = listNum;
                comboBoxNumber.DisplayMember = "Number";
                comboBoxNumber.ValueMember = "Id";
            }
            if (id.HasValue)
            {
                try
                {
                    var view = logic.Read(new SettingBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxCount.Text = view.CountPeople.ToString();
                        dateTimePicker1.Value = view.ArrivalDate;
                        dateTimePicker2.Value = view.DateDeparture;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Отмена_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Сохранение_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxClient.Text))
            {
                MessageBox.Show("Введите клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxNumber.Text))
            {
                MessageBox.Show("Введите номер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Введите Количество людей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(textBoxCount.Text) > 10)
            {
                MessageBox.Show("Максимальное количество людей в номере 10", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateTimePicker1.Value.Date >= dateTimePicker2.Value.Date)
            {
                MessageBox.Show("Дата прибытия должна быть меньше даты выезда");
                return;
            }
            try
            {
                logic.CreateOrUpdate(new SettingBindingModel
                {
                    Id = id,
                    CountPeople = Convert.ToInt32(textBoxCount.Text),
                    ArrivalDate = dateTimePicker1.Value,
                    DateDeparture = dateTimePicker2.Value,
                    ClientId = comboBoxClient.Text,
                    NumberRoomId = comboBoxNumber.Text
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolStripTextBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < '0' || l > '9') && l != '\b')
            {
                if (textBoxCount.SelectionStart == 0)
                {
                    if (l == '.') e.Handled = true;
                }
                if (l != '.' || textBoxCount.Text.IndexOf(".") != -1)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
