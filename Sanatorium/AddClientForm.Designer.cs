namespace Sanatorium
{
    partial class AddClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxSeries = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxIssues = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.Сохранить = new System.Windows.Forms.Button();
            this.Отмена = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Город";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Место рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Номер телефона";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Тип документа";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Серия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Номер документа";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Выдан";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(196, 18);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(550, 22);
            this.textBoxFIO.TabIndex = 9;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(196, 97);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(550, 22);
            this.textBoxCity.TabIndex = 11;
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(196, 143);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(550, 22);
            this.textBoxPlace.TabIndex = 12;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(196, 60);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(230, 22);
            this.dateTimePicker.TabIndex = 10;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(196, 188);
            this.textBoxPhone.MaxLength = 11;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(550, 22);
            this.textBoxPhone.TabIndex = 13;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxPhone_KeyPress);
            // 
            // textBoxSeries
            // 
            this.textBoxSeries.Location = new System.Drawing.Point(196, 268);
            this.textBoxSeries.MaxLength = 4;
            this.textBoxSeries.Name = "textBoxSeries";
            this.textBoxSeries.Size = new System.Drawing.Size(550, 22);
            this.textBoxSeries.TabIndex = 15;
            this.textBoxSeries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxPhone_KeyPress);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(196, 312);
            this.textBoxNumber.MaxLength = 6;
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(550, 22);
            this.textBoxNumber.TabIndex = 16;
            this.textBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxPhone_KeyPress);
            // 
            // textBoxIssues
            // 
            this.textBoxIssues.Location = new System.Drawing.Point(196, 358);
            this.textBoxIssues.Name = "textBoxIssues";
            this.textBoxIssues.Size = new System.Drawing.Size(550, 22);
            this.textBoxIssues.TabIndex = 17;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Паспорт",
            "Водительские_права"});
            this.comboBoxType.Location = new System.Drawing.Point(196, 224);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(549, 24);
            this.comboBoxType.TabIndex = 14;
            // 
            // Сохранить
            // 
            this.Сохранить.Location = new System.Drawing.Point(441, 401);
            this.Сохранить.Name = "Сохранить";
            this.Сохранить.Size = new System.Drawing.Size(137, 37);
            this.Сохранить.TabIndex = 18;
            this.Сохранить.Text = "Сохранить";
            this.Сохранить.UseVisualStyleBackColor = true;
            this.Сохранить.Click += new System.EventHandler(this.Сохранить_Click);
            // 
            // Отмена
            // 
            this.Отмена.Location = new System.Drawing.Point(608, 401);
            this.Отмена.Name = "Отмена";
            this.Отмена.Size = new System.Drawing.Size(137, 37);
            this.Отмена.TabIndex = 19;
            this.Отмена.Text = "Отмена";
            this.Отмена.UseVisualStyleBackColor = true;
            this.Отмена.Click += new System.EventHandler(this.Отмена_Click);
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.Отмена);
            this.Controls.Add(this.Сохранить);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxIssues);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxSeries);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddClientForm";
            this.Text = "Добавление клиента";
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxSeries;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxIssues;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button Сохранить;
        private System.Windows.Forms.Button Отмена;
    }
}