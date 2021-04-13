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
    public partial class AddRoomForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly INumberRoomModel logic;
        private int? id;
        public AddRoomForm(INumberRoomModel logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void AddRoomForm_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = logic.Read(new NumberRoomBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxNumber.Text = view.Number.ToString();
                        textBoxType.Text = view.Type;
                        textBoxFloor.Text = view.Floor.ToString();
                        textBoxPrice.Text = view.Price.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        private void Сохранение_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBox.Show("Введите №", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxType.Text))
            {
                MessageBox.Show("Введите Тип", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxFloor.Text))
            {
                MessageBox.Show("Введите Этаж", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPrice.Text))
            {
                MessageBox.Show("Введите Цену", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxPrice.Text.IndexOf(',') > 0)
            {
                if (textBoxPrice.Text.Substring(textBoxPrice.Text.IndexOf(',')).Length > 3)
                {
                    MessageBox.Show("Цена должна иметь два знака после запятой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            try
            {
                logic.CreateOrUpdate(new NumberRoomBindingModel
                {
                    Id = id,
                    Number = Convert.ToInt32(textBoxNumber.Text),
                    Type = textBoxType.Text,
                    Floor = Convert.ToInt32(textBoxFloor.Text),
                    Price = Convert.ToDouble(textBoxPrice.Text),
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
                if (textBoxNumber.SelectionStart == 0)
                {
                    if (l == '.') e.Handled = true;
                }
                if (l != '.' || textBoxNumber.Text.IndexOf(".") != -1)
                {
                    e.Handled = true;
                }
            }
        }
        private void TextBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < '0' || l > '9') && l != '\b')
            {
                if (textBoxPrice.SelectionStart == 0)
                {
                    if (l == ',') e.Handled = true;
                }
                if (l != ',' || textBoxPrice.Text.IndexOf(",") != -1)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
