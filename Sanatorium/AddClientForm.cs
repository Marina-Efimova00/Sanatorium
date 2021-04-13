using BussinesLogic.BindingModel;
using BussinesLogic.Enums;
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
    public partial class AddClientForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly IClientModel logic;
        private int? id;
        public AddClientForm(IClientModel logic)
        {
            InitializeComponent();
            this.logic = logic;
        }
        
        private void AddClientForm_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = logic.Read(new ClientBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxFIO.Text = view.FIO;
                        dateTimePicker.Value = view.DateBirthday;
                        textBoxCity.Text = view.City;
                        textBoxPlace.Text = view.PlaceResident;
                        textBoxPhone.Text = view.Phone.ToString();
                        comboBoxType.Text = view.TypeDocument;
                        textBoxSeries.Text = view.Series.ToString();
                        textBoxNumber.Text = view.NumberDocument.ToString();
                        textBoxIssues.Text = view.Issued;
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

        private void Сохранить_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFIO.Text))
            {
                MessageBox.Show("Введите ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCity.Text))
            {
                MessageBox.Show("Введите Город", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPlace.Text))
            {
                MessageBox.Show("Введите Место рождения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPhone.Text))
            {
                MessageBox.Show("Введите Номер телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxType.Text))
            {
                MessageBox.Show("Введите Тип документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxSeries.Text))
            {
                MessageBox.Show("Введите Серию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBox.Show("Введите Номер документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxIssues.Text))
            {
                MessageBox.Show("Введите кем выдан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                logic.CreateOrUpdate(new ClientBindingModel
                {
                    Id = id,
                    FIO = textBoxFIO.Text,
                    DateBirthday = dateTimePicker.Value,
                    City = textBoxCity.Text,
                    PlaceResident = textBoxPlace.Text,
                    Phone = Convert.ToInt32(textBoxNumber.Text),
                    TypeDocument = comboBoxType.Text,
                    Series = Convert.ToInt32(textBoxSeries.Text),
                    NumberDocument = Convert.ToInt32(textBoxNumber.Text),
                    Issued = textBoxIssues.Text,
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
        private void Отмена_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void toolStripTextBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < '0' || l > '9') && l != '\b')
            {
                if (textBoxPhone.SelectionStart == 0)
                {
                    if (l == '.') e.Handled = true;
                }
                if (l != '.' || textBoxPhone.Text.IndexOf(".") != -1)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
