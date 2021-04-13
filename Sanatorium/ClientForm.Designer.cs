namespace Sanatorium
{
    partial class ClientForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Добавить = new System.Windows.Forms.Button();
            this.Редактировать = new System.Windows.Forms.Button();
            this.Удалить = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 546);
            this.dataGridView1.TabIndex = 0;
            // 
            // Добавить
            // 
            this.Добавить.Location = new System.Drawing.Point(1067, 12);
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(154, 41);
            this.Добавить.TabIndex = 1;
            this.Добавить.Text = "Добавить";
            this.Добавить.UseVisualStyleBackColor = true;
            this.Добавить.Click += new System.EventHandler(this.Добавить_Click);
            // 
            // Редактировать
            // 
            this.Редактировать.Location = new System.Drawing.Point(1067, 75);
            this.Редактировать.Name = "Редактировать";
            this.Редактировать.Size = new System.Drawing.Size(154, 41);
            this.Редактировать.TabIndex = 2;
            this.Редактировать.Text = "Редактировать";
            this.Редактировать.UseVisualStyleBackColor = true;
            this.Редактировать.Click += new System.EventHandler(this.Редактировать_Click);
            // 
            // Удалить
            // 
            this.Удалить.Location = new System.Drawing.Point(1067, 146);
            this.Удалить.Name = "Удалить";
            this.Удалить.Size = new System.Drawing.Size(154, 41);
            this.Удалить.TabIndex = 3;
            this.Удалить.Text = "Удалить";
            this.Удалить.UseVisualStyleBackColor = true;
            this.Удалить.Click += new System.EventHandler(this.Удалить_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sanatorium.Properties.Resources.b128_ho_00_p_1024x768;
            this.ClientSize = new System.Drawing.Size(1233, 565);
            this.Controls.Add(this.Удалить);
            this.Controls.Add(this.Редактировать);
            this.Controls.Add(this.Добавить);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientForm";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Добавить;
        private System.Windows.Forms.Button Редактировать;
        private System.Windows.Forms.Button Удалить;
    }
}