namespace Sanatorium
{
    partial class MainForm
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
            this.Клиенты = new System.Windows.Forms.Button();
            this.Номера = new System.Windows.Forms.Button();
            this.Заселение = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Клиенты
            // 
            this.Клиенты.Location = new System.Drawing.Point(318, 21);
            this.Клиенты.Name = "Клиенты";
            this.Клиенты.Size = new System.Drawing.Size(151, 44);
            this.Клиенты.TabIndex = 0;
            this.Клиенты.Text = "Клиенты";
            this.Клиенты.UseVisualStyleBackColor = true;
            this.Клиенты.Click += new System.EventHandler(this.Клиенты_Click);
            // 
            // Номера
            // 
            this.Номера.Location = new System.Drawing.Point(318, 97);
            this.Номера.Name = "Номера";
            this.Номера.Size = new System.Drawing.Size(151, 44);
            this.Номера.TabIndex = 1;
            this.Номера.Text = "Номера";
            this.Номера.UseVisualStyleBackColor = true;
            this.Номера.Click += new System.EventHandler(this.Номера_Click);
            // 
            // Заселение
            // 
            this.Заселение.Location = new System.Drawing.Point(318, 166);
            this.Заселение.Name = "Заселение";
            this.Заселение.Size = new System.Drawing.Size(151, 44);
            this.Заселение.TabIndex = 2;
            this.Заселение.Text = "Заселение";
            this.Заселение.UseVisualStyleBackColor = true;
            this.Заселение.Click += new System.EventHandler(this.Заселение_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sanatorium.Properties.Resources.b128_ho_00_p_1024x768;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 415);
            this.Controls.Add(this.Заселение);
            this.Controls.Add(this.Номера);
            this.Controls.Add(this.Клиенты);
            this.Name = "MainForm";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Клиенты;
        private System.Windows.Forms.Button Номера;
        private System.Windows.Forms.Button Заселение;
    }
}