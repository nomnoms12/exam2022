namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(276, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(44, 124);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(100, 20);
            this.surname.TabIndex = 1;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(362, 124);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 20);
            this.year.TabIndex = 2;
            // 
            // patronymic
            // 
            this.patronymic.Location = new System.Drawing.Point(256, 124);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(100, 20);
            this.patronymic.TabIndex = 3;
            this.patronymic.Leave += new System.EventHandler(this.patronymic_Leave);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(150, 124);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 295);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.year);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button button1;
    }
}

