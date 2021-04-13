namespace Sanatorium
{
    partial class AddRoomForm
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
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.Сохранение = new System.Windows.Forms.Button();
            this.Отмена = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "№";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Этаж";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(85, 24);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(530, 22);
            this.textBoxNumber.TabIndex = 5;
            this.textBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxPhone_KeyPress);
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(85, 67);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(530, 22);
            this.textBoxType.TabIndex = 6;
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Location = new System.Drawing.Point(85, 109);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(530, 22);
            this.textBoxFloor.TabIndex = 7;
            this.textBoxFloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxPhone_KeyPress);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(85, 151);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(530, 22);
            this.textBoxPrice.TabIndex = 8;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPhone_KeyPress);
            // 
            // Сохранение
            // 
            this.Сохранение.Location = new System.Drawing.Point(383, 195);
            this.Сохранение.Name = "Сохранение";
            this.Сохранение.Size = new System.Drawing.Size(108, 35);
            this.Сохранение.TabIndex = 9;
            this.Сохранение.Text = "Сохранение";
            this.Сохранение.UseVisualStyleBackColor = true;
            this.Сохранение.Click += new System.EventHandler(this.Сохранение_Click);
            // 
            // Отмена
            // 
            this.Отмена.Location = new System.Drawing.Point(507, 195);
            this.Отмена.Name = "Отмена";
            this.Отмена.Size = new System.Drawing.Size(108, 35);
            this.Отмена.TabIndex = 10;
            this.Отмена.Text = "Отмена";
            this.Отмена.UseVisualStyleBackColor = true;
            this.Отмена.Click += new System.EventHandler(this.Отмена_Click);
            // 
            // AddRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 242);
            this.Controls.Add(this.Отмена);
            this.Controls.Add(this.Сохранение);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxFloor);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRoomForm";
            this.Text = "Добавление номера";
            this.Load += new System.EventHandler(this.AddRoomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button Сохранение;
        private System.Windows.Forms.Button Отмена;
    }
}